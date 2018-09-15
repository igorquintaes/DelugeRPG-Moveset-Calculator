using System;
using System.Collections.Generic;
using System.Linq;

namespace Deluge.Calculator.MoveSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = AttackDatabase.ObtainData();

            Console.WriteLine("Type your enemy team type, splitting a dual-type pokémon using comma.");
            Console.WriteLine("Press enter to input a new pokémon and/or 'start' if the pokémon quantity is lower than 6.");
            Console.WriteLine("You can also enter a negative pokemon");
            Console.WriteLine("Example.");
            Console.WriteLine("Dragon, Water");
            Console.WriteLine("Fire");
            Console.WriteLine("Grass, Ice, Negative");
            Console.WriteLine("start");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Type your enemy team type here:");

            var enemyTypesList = new List<PokemonAttacks>();
            AttackType parseResult;

            for (var count = 0; count < 6; count++)
            {
                var pokemonAttacks = new PokemonAttacks();

                var type = Console.ReadLine();

                if (type.ToLower() == "start")
                    break;
                
                pokemonAttacks.Inverse = type.Split(',').Any(x => x.Trim().ToLower() == "negative");

                Enum.TryParse(type.Split(',').First(x => x.Trim().ToLower() != "negative"), out parseResult);
                pokemonAttacks.Primary = parseResult;
                Enum.TryParse(type.Split(',').Last(x => x.Trim().ToLower() != "negative"), out parseResult);
                pokemonAttacks.Secondary = parseResult;

                enemyTypesList.Add(pokemonAttacks);
            }

            Console.WriteLine("Is a inverse battle? (true / false):");
            var isInverse = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Calculating the better movelist...");

            var betterAttacksAll = new List<Tuple<PokemonAttacks, List<Attack>>>();
            foreach (var enemyTypes in enemyTypesList)
            {
                var powerVariationList = Calculator.Calculate(enemyTypes.Primary, enemyTypes.Secondary, isInverse);
                var resultBestAttackBatch = Calculator.GetBestAttackAllTypes(data, powerVariationList).OrderByDescending(x => x.Power).ToList();
                betterAttacksAll.Add(new Tuple<PokemonAttacks, List<Attack>>(enemyTypes, resultBestAttackBatch));
            }

            var extraSlots = betterAttacksAll.Count - 4;
            extraSlots = extraSlots < 0 ? 0 : extraSlots;

            var combinations = GetKCombs(betterAttacksAll, extraSlots + 1);
            if (combinations.First().Count() == 1)
            {
                var allCombinations = UpdateRemainingCombinations(betterAttacksAll);
                PrintResult(allCombinations);
                return;

            }
            if (combinations.First().Count() == 2)
            {
                var strongestCombination = GetStrongestCombination(combinations);
                var allCombinations = new List<Tuple<List<PokemonAttacks>, Attack>>();
                allCombinations.Add(strongestCombination);
                allCombinations.AddRange(UpdateRemainingCombinations(betterAttacksAll.Where(x => !strongestCombination.Item1.Contains(x.Item1))));
                PrintResult(allCombinations);
                return;
            }
            if (combinations.First().Count() == 3)
            {

                var strongestTripleCombination = GetStrongestCombination(combinations);

                var dualCombinations = GetKCombs(betterAttacksAll, 2);
                var strongestDualCombination1 = GetStrongestCombination(dualCombinations);

                var dualCombinationsWithoutTop = GetKCombs(betterAttacksAll.Where(x => !strongestDualCombination1.Item1.Contains(x.Item1)), 2);
                var strongestDualCombination2 = GetStrongestCombination(dualCombinationsWithoutTop);

                var allCombinations = new List<Tuple<List<PokemonAttacks>, Attack>>();
                if (strongestTripleCombination.Item2.Power < strongestDualCombination2.Item2.Power + strongestDualCombination1.Item2.Power)
                {
                    allCombinations.Add(strongestDualCombination1);
                    allCombinations.Add(strongestDualCombination2);
                    allCombinations.AddRange(UpdateRemainingCombinations(betterAttacksAll.Where(x =>
                        !strongestDualCombination1.Item1.Contains(x.Item1) &&
                        !strongestDualCombination2.Item1.Contains(x.Item1))));
                    PrintResult(allCombinations);
                    return;
                }

                allCombinations.Add(strongestTripleCombination);
                allCombinations.AddRange(UpdateRemainingCombinations(betterAttacksAll.Where(x =>
                    !strongestTripleCombination.Item1.Contains(x.Item1))));
                PrintResult(allCombinations);
            }
        }

        public static Tuple<List<PokemonAttacks>, Attack> GetStrongestCombination(IEnumerable<IEnumerable<Tuple<PokemonAttacks, List<Attack>>>> kCombinations)
        {
            var strongestCombination = new Tuple<List<PokemonAttacks>, Attack>(new List<PokemonAttacks>(), new Attack());
            foreach (var combination in kCombinations)
            {
                for (var count = 0; count < combination.First().Item2.Count; count++)
                {
                    var attacks = combination.ToList().Skip(1)
                        .Select(x => x.Item2.First(y => y.Name == combination.ToList()[0].Item2[count].Name && y.Type == combination.ToList()[0].Item2[count].Type))
                        .ToList();

                    attacks.Add(combination.ToList()[0].Item2[count]);

                    var atkResult = new Attack(attacks.First().Name, attacks.First().Type.ToString(), attacks.Sum(x => x.Power) / 3);

                    if (atkResult.Power > strongestCombination.Item2.Power && attacks.All(x => x.Power > 0))
                    {
                        strongestCombination = new Tuple<List<PokemonAttacks>, Attack>(combination.ToList().Select(x => x.Item1).ToList(), atkResult);
                    }
                }
            }

            return strongestCombination;
        }

        public static IEnumerable<Tuple<List<PokemonAttacks>, Attack>> UpdateRemainingCombinations(IEnumerable<Tuple<PokemonAttacks, List<Attack>>> remainingEnemies) =>
            remainingEnemies.Select(x => new Tuple<List<PokemonAttacks>, Attack>(
                item1: new List<PokemonAttacks>() { x.Item1 },
                item2: x.Item2.OrderByDescending(y => y.Power).First()));

        public static IEnumerable<IEnumerable<Tuple<PokemonAttacks, List<Attack>>>> GetKCombs(IEnumerable<Tuple<PokemonAttacks, List<Attack>>> list, int length)
        {
            if (length < 1) throw new ArgumentOutOfRangeException(nameof(length));
            if (length == 1) return list.Select(t => new Tuple<PokemonAttacks, List<Attack>>[] { t });
;
            return Combinations(list.ToList(), length).ToList();
        }

        public static void PrintResult(IEnumerable<Tuple<List<PokemonAttacks>, Attack>> results)
        {
            Console.Clear();

            foreach (var result in results)
            {
                Console.WriteLine(string.Join("& ", result.Item1.Select(x => $"{x.Primary.ToString()} {(x.Secondary == x.Primary ? "" : x.Secondary.ToString())}{(x.Inverse ? " Negative" : "")}")));
                Console.WriteLine($"{result.Item2.Name}, of type {result.Item2.Type} - Power variation: {result.Item2.Power}{Environment.NewLine}");
            }

            Console.ReadKey();
        }

        private static IEnumerable<int[]> CombinationsRosettaWoRecursion(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>(m);
            stack.Push(0);
            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();
                while (value < n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index != m) continue;
                    yield return result;
                    break;
                }
            }
        }

        public static IEnumerable<T[]> Combinations<T>(List<T> array, int m)
        {
            T[] result = new T[m];
            foreach (int[] j in CombinationsRosettaWoRecursion(m, array.Count))
            {
                for (int i = 0; i < m; i++)
                {
                    result[i] = array[j[i]];
                }
                yield return result;
            }
        }
    }
}

