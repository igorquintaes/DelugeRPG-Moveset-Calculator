using System;
using System.Collections.Generic;
using System.Linq;

namespace Deluge.Calculator.MoveSet
{
    public static class Calculator
    {
        private const double _strong = 2;
        private const double _normal = 1;
        private const double _weak = 0.5;
        private const double _immune = 0;

        public static List<KeyValuePair<AttackType, double>> Calculate(AttackType enemyType, bool inverse = false)
        {
            var data = new List<KeyValuePair<AttackType, double>>();
            var itensTochange = new List<KeyValuePair<AttackType, double>>();
            data.AddRange(Enum.GetValues(typeof(AttackType)).OfType<AttackType>().Select(x => new KeyValuePair<AttackType, double>(x, _normal)));

            switch (enemyType)
            {
                case AttackType.normal:
                    AddImuneTypes(itensTochange,
                        AttackType.ghost);
                    AddStrongTypes(itensTochange,
                        AttackType.fighting);
                    break;
                case AttackType.fire:
                    AddWeakTypes(itensTochange,
                        AttackType.fire,
                        AttackType.grass,
                        AttackType.ice,
                        AttackType.bug,
                        AttackType.steel,
                        AttackType.fairy);
                    AddStrongTypes(itensTochange,
                        AttackType.water,
                        AttackType.ground,
                        AttackType.rock);
                    break;
                case AttackType.water:
                    AddWeakTypes(itensTochange,
                        AttackType.fire,
                        AttackType.water,
                        AttackType.ice,
                        AttackType.steel);
                    AddStrongTypes(itensTochange,
                        AttackType.electric,
                        AttackType.grass);
                    break;
                case AttackType.electric:
                    AddWeakTypes(itensTochange,
                        AttackType.electric,
                        AttackType.flying,
                        AttackType.steel);
                    AddStrongTypes(itensTochange,
                        AttackType.ground);
                    break;
                case AttackType.grass:
                    AddWeakTypes(itensTochange,
                        AttackType.water,
                        AttackType.electric,
                        AttackType.grass,
                        AttackType.ground);
                    AddStrongTypes(itensTochange,
                        AttackType.fire,
                        AttackType.ice,
                        AttackType.poison,
                        AttackType.flying,
                        AttackType.bug);
                    break;
                case AttackType.ice:
                    AddWeakTypes(itensTochange,
                        AttackType.ice);
                    AddStrongTypes(itensTochange,
                        AttackType.fire,
                        AttackType.fighting,
                        AttackType.rock,
                        AttackType.steel);
                    break;
                case AttackType.fighting:
                    AddWeakTypes(itensTochange,
                        AttackType.bug,
                        AttackType.rock,
                        AttackType.dark);
                    AddStrongTypes(itensTochange,
                        AttackType.flying,
                        AttackType.psychic,
                        AttackType.fairy);
                    break;
                case AttackType.poison:
                    AddWeakTypes(itensTochange,
                        AttackType.grass,
                        AttackType.fighting,
                        AttackType.poison,
                        AttackType.bug,
                        AttackType.fairy);
                    AddStrongTypes(itensTochange,
                        AttackType.ground,
                        AttackType.psychic);
                    break;
                case AttackType.ground:
                    AddImuneTypes(itensTochange,
                        AttackType.electric);
                    AddWeakTypes(itensTochange,
                        AttackType.poison,
                        AttackType.rock);
                    AddStrongTypes(itensTochange,
                        AttackType.water,
                        AttackType.grass,
                        AttackType.ice);
                    break;
                case AttackType.flying:
                    AddImuneTypes(itensTochange,
                        AttackType.ground);
                    AddWeakTypes(itensTochange,
                        AttackType.grass,
                        AttackType.fighting,
                        AttackType.bug);
                    AddStrongTypes(itensTochange,
                        AttackType.electric,
                        AttackType.ice,
                        AttackType.rock);
                    break;
                case AttackType.psychic:
                    AddWeakTypes(itensTochange,
                        AttackType.fighting,
                        AttackType.psychic);
                    AddStrongTypes(itensTochange,
                        AttackType.bug,
                        AttackType.ghost,
                        AttackType.dark);
                    break;
                case AttackType.bug:
                    AddWeakTypes(itensTochange,
                        AttackType.grass,
                        AttackType.fighting,
                        AttackType.ground);
                    AddStrongTypes(itensTochange,
                        AttackType.fire,
                        AttackType.flying,
                        AttackType.rock);
                    break;
                case AttackType.rock:
                    AddWeakTypes(itensTochange,
                        AttackType.normal,
                        AttackType.fire,
                        AttackType.poison,
                        AttackType.flying);
                    AddStrongTypes(itensTochange,
                        AttackType.water,
                        AttackType.grass,
                        AttackType.fighting,
                        AttackType.ground,
                        AttackType.steel);
                    break;
                case AttackType.ghost:
                    AddImuneTypes(itensTochange,
                        AttackType.normal,
                        AttackType.fighting);
                    AddWeakTypes(itensTochange,
                        AttackType.poison,
                        AttackType.bug);
                    AddStrongTypes(itensTochange,
                        AttackType.ghost,
                        AttackType.dark);
                    break;
                case AttackType.dragon:
                    AddWeakTypes(itensTochange,
                        AttackType.fire,
                        AttackType.water,
                        AttackType.electric,
                        AttackType.grass);
                    AddStrongTypes(itensTochange,
                        AttackType.ice,
                        AttackType.dragon,
                        AttackType.fairy);
                    break;
                case AttackType.dark:
                    AddImuneTypes(itensTochange,
                        AttackType.psychic);
                    AddWeakTypes(itensTochange,
                        AttackType.ghost,
                        AttackType.dark);
                    AddStrongTypes(itensTochange,
                        AttackType.fighting,
                        AttackType.bug,
                        AttackType.fairy);
                    break;
                case AttackType.steel:
                    AddImuneTypes(itensTochange,
                        AttackType.poison);
                    AddWeakTypes(itensTochange,
                        AttackType.normal,
                        AttackType.grass,
                        AttackType.ice,
                        AttackType.flying,
                        AttackType.psychic,
                        AttackType.bug,
                        AttackType.rock,
                        AttackType.dragon,
                        AttackType.steel,
                        AttackType.fairy);
                    AddStrongTypes(itensTochange,
                        AttackType.fire,
                        AttackType.fighting,
                        AttackType.ground);
                    break;
                case AttackType.fairy:
                    AddImuneTypes(itensTochange,
                        AttackType.dragon);
                    AddWeakTypes(itensTochange,
                        AttackType.fighting,
                        AttackType.bug,
                        AttackType.dark);
                    AddStrongTypes(itensTochange,
                        AttackType.poison,
                        AttackType.steel);
                    break;
            }

            return ChangeItems(data, itensTochange, inverse);
        }

        public static List<KeyValuePair<AttackType, double>> Calculate(AttackType enemyFirstType, AttackType enemySecondType, bool inverse = false)
        {
            if (enemyFirstType == enemySecondType)
                return Calculate(enemyFirstType, inverse);

            var enemyAttacksFirstType = Calculate(enemyFirstType, inverse);
            var enemyAttacksSecondType = Calculate(enemySecondType, inverse);

            var result = new List<KeyValuePair<AttackType, double>>();
            for (var i = 0; i < enemyAttacksFirstType.Count; i++)
            {
                result.Add(new KeyValuePair<AttackType, double>(
                    enemyAttacksFirstType[i].Key,
                    enemyAttacksFirstType[i].Value * enemyAttacksSecondType[i].Value));
            }

            return result;
        }

        public static Attack GetBestAttack(List<Attack> moves, List<KeyValuePair<AttackType, double>> attackMetrics)
        {
            var strongestAttack = new KeyValuePair<Attack, double>(moves.First(), 0);
            foreach (var move in moves)
            {
                var power = attackMetrics.Single(x => x.Key == move.Type).Value * move.Power;
                if (power > strongestAttack.Value)
                    strongestAttack = new KeyValuePair<Attack, double>(move, power);
            }

            return strongestAttack.Key;
        }

        public static List<Attack> GetBestAttackAllTypes(List<Attack> allMoves, List<KeyValuePair<AttackType, double>> attackMetrics)
        {
            return allMoves
                .Where(x => x.Power < 200)
                .Select(x => new Attack(x.Name, x.Type.ToString(), Convert.ToInt32(x.Power * attackMetrics.First(y => y.Key == x.Type).Value)))
                .ToList();
        }

        private static void AddWeakTypes(List<KeyValuePair<AttackType, double>> data, params AttackType[] types) =>
            data.AddRange(types.Select(x => new KeyValuePair<AttackType, double>(x, _weak)));

        private static void AddStrongTypes(List<KeyValuePair<AttackType, double>> data, params AttackType[] types) =>
            data.AddRange(types.Select(x => new KeyValuePair<AttackType, double>(x, _strong)));

        private static void AddImuneTypes(List<KeyValuePair<AttackType, double>> data, params AttackType[] types) =>
            data.AddRange(types.Select(x => new KeyValuePair<AttackType, double>(x, _immune)));

        private static List<KeyValuePair<AttackType, double>> ChangeItems(
            List<KeyValuePair<AttackType, double>> data,
            List<KeyValuePair<AttackType, double>> itensTochange,
            bool inverse)
        {
            foreach (var itemToChange in itensTochange)
            {
                var i = data.FindIndex(n => n.Key.Equals(itemToChange.Key));
                if (inverse && (itemToChange.Value == _weak || itemToChange.Value == _immune))
                    data[i] = new KeyValuePair<AttackType, double>(itemToChange.Key, _strong);
                else if (inverse && itemToChange.Value == _strong)
                    data[i] = new KeyValuePair<AttackType, double>(itemToChange.Key, _weak);
                else
                    data[i] = itemToChange;
            }

            return data;
        }
    }
}