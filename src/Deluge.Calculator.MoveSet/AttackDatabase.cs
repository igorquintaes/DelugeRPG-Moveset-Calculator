﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Deluge.Calculator.MoveSet
{
    public static class AttackDatabase
    {
        public static List<Attack> ObtainData() => (new Attack[] {
                new Attack("10,000,000 volt thunderbolt", "electric", 200 ),
                new Attack("acid downpour", "poison", 200 ),
                new Attack("all-out pummeling", "fighting", 200 ),
                new Attack("black hole eclipse", "dark", 200 ),
                new Attack("bloom doom", "grass", 200 ),
                new Attack("breakneck blitz", "normal", 200 ),
                new Attack("catastropika", "electric", 200 ),
                new Attack("clangorous soulblaze", "dragon", 200 ),
                new Attack("continental crush", "rock", 200 ),
                new Attack("corkscrew crash", "steel", 200 ),
                new Attack("devastating drake", "dragon", 200 ),
                new Attack("extreme evoboost", "normal", 200 ),
                new Attack("genesis supernova", "psychic", 200 ),
                new Attack("gigavolt havoc", "electric", 200 ),
                new Attack("guardian of alola", "fairy", 200 ),
                new Attack("hydro vortex", "water", 200 ),
                new Attack("inferno overdrive", "fire", 200 ),
                new Attack("let's snuggle forever", "fairy", 200 ),
                new Attack("light that burns the sky", "psychic", 200 ),
                new Attack("malicious moonsault", "dark", 200 ),
                new Attack("menacing moonraze maelstrom", "ghost", 200 ),
                new Attack("never-ending nightmare", "ghost", 200 ),
                new Attack("oceanic operetta", "water", 200 ),
                new Attack("pulverizing pancake", "normal", 200 ),
                new Attack("savage spin-out", "bug", 200 ),
                new Attack("searing sunraze smash", "steel", 200 ),
                new Attack("shattered psyche", "psychic", 200 ),
                new Attack("sinister arrow raid", "ghost", 200 ),
                new Attack("soul-stealing 7-star strike", "ghost", 200 ),
                new Attack("splintered stormshards", "rock", 200 ),
                new Attack("stoked sparksurfer", "electric", 200 ),
                new Attack("subzero slammer", "ice", 200 ),
                new Attack("supersonic skystrike", "flying", 200 ),
                new Attack("tectonic rage", "ground", 200 ),
                new Attack("twinkle tackle", "fairy", 200 ),
                new Attack("explosion", "normal", 175 ),
                new Attack("v-create", "fire", 170 ),
                new Attack("prismatic laser", "psychic", 160 ),
                new Attack("blast burn", "fire", 150 ),
                new Attack("eruption", "fire", 150 ),
                new Attack("focus punch", "fighting", 150 ),
                new Attack("frenzy plant", "grass", 150 ),
                new Attack("giga impact", "normal", 150 ),
                new Attack("head smash", "rock", 150 ),
                new Attack("hydro cannon", "water", 150 ),
                new Attack("hyper beam", "normal", 150 ),
                new Attack("mind blown", "fire", 150 ),
                new Attack("roar of time", "dragon", 150 ),
                new Attack("rock wrecker", "rock", 150 ),
                new Attack("shell trap", "fire", 150 ),
                new Attack("water spout", "water", 150 ),
                new Attack("boomburst", "normal", 140 ),
                new Attack("doom desire", "steel", 140 ),
                new Attack("freeze shock", "ice", 140 ),
                new Attack("ice burn", "ice", 140 ),
                new Attack("light of ruin", "fairy", 140 ),
                new Attack("outrage", "dragon", 140 ),
                new Attack("psycho boost", "psychic", 140 ),
                new Attack("sky attack", "flying", 140 ),
                new Attack("belch", "poison", 130 ),
                new Attack("blue flare", "fire", 130 ),
                new Attack("bolt strike", "electric", 130 ),
                new Attack("draco meteor", "dragon", 130 ),
                new Attack("fleur cannon", "fairy", 130 ),
                new Attack("hi jump kick", "fighting", 130 ),
                new Attack("hyperspace fury", "dark", 130 ),
                new Attack("leaf storm", "grass", 130 ),
                new Attack("megahorn", "bug", 130 ),
                new Attack("nature's madness", "fairy", 130 ),
                new Attack("overheat", "fire", 130 ),
                new Attack("precipice blades", "ground", 130 ),
                new Attack("shadow force", "ghost", 130 ),
                new Attack("skull bash", "normal", 130 ),
                new Attack("solar blade", "grass", 125 ),
                new Attack("brave bird", "flying", 120 ),
                new Attack("close combat", "fighting", 120 ),
                new Attack("double-edge", "normal", 120 ),
                new Attack("dragon ascent", "flying", 120 ),
                new Attack("flare blitz", "fire", 120 ),
                new Attack("focus blast", "fighting", 120 ),
                new Attack("fusion bolt", "electric", 120 ),
                new Attack("fusion flare", "fire", 120 ),
                new Attack("gunk shot", "poison", 120 ),
                new Attack("head charge", "normal", 120 ),
                new Attack("last resort", "normal", 120 ),
                new Attack("magma storm", "fire", 120 ),
                new Attack("mega kick", "normal", 120 ),
                new Attack("petal dance", "grass", 120 ),
                new Attack("power whip", "grass", 120 ),
                new Attack("seed flare", "grass", 120 ),
                new Attack("solarbeam", "grass", 120 ),
                new Attack("superpower", "fighting", 120 ),
                new Attack("synchronoise", "psychic", 120 ),
                new Attack("volt tackle", "electric", 120 ),
                new Attack("wood hammer", "grass", 120 ),
                new Attack("zap cannon", "electric", 120 ),
                new Attack("blizzard", "ice", 110 ),
                new Attack("clanging scales", "dragon", 110 ),
                new Attack("fire blast", "fire", 110 ),
                new Attack("hurricane", "flying", 110 ),
                new Attack("hydro pump", "water", 110 ),
                new Attack("origin pulse", "water", 110 ),
                new Attack("steam eruption", "water", 110 ),
                new Attack("thrash", "normal", 110 ),
                new Attack("thunder", "electric", 110 ),
                new Attack("uproar", "normal", 110 ),
                new Attack("aeroblast", "flying", 100 ),
                new Attack("beak blast", "flying", 100 ),
                new Attack("core enforcer", "dragon", 100 ),
                new Attack("crabhammer", "water", 100 ),
                new Attack("cross chop", "fighting", 100 ),
                new Attack("diamond storm", "rock", 100 ),
                new Attack("dragon rush", "dragon", 100 ),
                new Attack("dynamicpunch", "fighting", 100 ),
                new Attack("earthquake", "ground", 100 ),
                new Attack("egg bomb", "normal", 100 ),
                new Attack("final gambit", "fighting", 100 ),
                new Attack("fissure", "ground", 100 ),
                new Attack("hammer arm", "fighting", 100 ),
                new Attack("ice hammer", "ice", 100 ),
                new Attack("inferno", "fire", 100 ),
                new Attack("iron tail", "steel", 100 ),
                new Attack("judgment", "normal", 100 ),
                new Attack("jump kick", "fighting", 100 ),
                new Attack("moongeist beam", "ghost", 100 ),
                new Attack("photon geyser", "psychic", 100 ),
                new Attack("plasma fists", "electric", 100 ),
                new Attack("psystrike", "psychic", 100 ),
                new Attack("sacred fire", "fire", 100 ),
                new Attack("searing shot", "fire", 100 ),
                new Attack("sheer cold", "ice", 100 ),
                new Attack("spacial rend", "dragon", 100 ),
                new Attack("stone edge", "rock", 100 ),
                new Attack("sunsteel strike", "steel", 100 ),
                new Attack("foul play", "dark", 95),
                new Attack("heat wave", "fire", 95),
                new Attack("high horsepower", "ground", 95),
                new Attack("moonblast", "fairy", 95),
                new Attack("sludge wave", "poison", 95),
                new Attack("aqua tail", "water", 90),
                new Attack("attack order", "bug", 90),
                new Attack("bug buzz", "bug", 90),
                new Attack("dragon hammer", "dragon", 90),
                new Attack("earth power", "ground", 90),
                new Attack("energy ball", "grass", 90),
                new Attack("facade", "normal", 90),
                new Attack("first impression", "bug", 90),
                new Attack("flamethrower", "fire", 90),
                new Attack("fly", "flying", 90),
                new Attack("guillotine", "normal", 90),
                new Attack("hyper voice", "normal", 90),
                new Attack("ice beam", "ice", 90),
                new Attack("leaf blade", "grass", 90),
                new Attack("meteor mash", "steel", 90),
                new Attack("muddy water", "water", 90),
                new Attack("multi-attack", "normal", 90),
                new Attack("petal blizzard", "grass", 90),
                new Attack("phantom force", "ghost", 90),
                new Attack("play rough", "fairy", 90),
                new Attack("pollen puff", "bug", 90),
                new Attack("psychic", "psychic", 90),
                new Attack("revelation dance", "normal", 90),
                new Attack("rock climb", "normal", 90),
                new Attack("sacred sword", "fighting", 90),
                new Attack("sludge bomb", "poison", 90),
                new Attack("spectral thief", "ghost", 90),
                new Attack("surf", "water", 90),
                new Attack("take down", "normal", 90),
                new Attack("thunderbolt", "electric", 90),
                new Attack("wild charge", "electric", 90),
                new Attack("blaze kick", "fire", 85),
                new Attack("body slam", "normal", 85),
                new Attack("bounce", "flying", 85),
                new Attack("darkest lariat", "dark", 85),
                new Attack("dragon pulse", "dragon", 85),
                new Attack("icicle crash", "ice", 85),
                new Attack("liquidation", "water", 85),
                new Attack("night daze", "dark", 85),
                new Attack("psychic fangs", "psychic", 85),
                new Attack("secret sword", "fighting", 85),
                new Attack("shadow bone", "ghost", 85),
                new Attack("sky uppercut", "fighting", 85),
                new Attack("techno blast", "normal", 85),
                new Attack("anchor shot", "steel", 80),
                new Attack("aura sphere", "fighting", 80),
                new Attack("crunch", "dark", 80),
                new Attack("dark pulse", "dark", 80),
                new Attack("dazzling gleam", "fairy", 80),
                new Attack("discharge", "electric", 80),
                new Attack("dive", "water", 80),
                new Attack("dragon claw", "dragon", 80),
                new Attack("drill peck", "flying", 80),
                new Attack("drill run", "ground", 80),
                new Attack("electro ball", "electric", 80),
                new Attack("extrasensory", "psychic", 80),
                new Attack("extremespeed", "normal", 80),
                new Attack("fiery dance", "fire", 80),
                new Attack("fire lash", "fire", 80),
                new Attack("flash cannon", "steel", 80),
                new Attack("flying press", "fighting", 80),
                new Attack("hyper fang", "normal", 80),
                new Attack("hyperspace hole", "psychic", 80),
                new Attack("iron head", "steel", 80),
                new Attack("lava plume", "fire", 80),
                new Attack("mega punch", "normal", 80),
                new Attack("oblivion wing", "flying", 80),
                new Attack("poison jab", "poison", 80),
                new Attack("power gem", "rock", 80),
                new Attack("psyshock", "psychic", 80),
                new Attack("razor wind", "normal", 80),
                new Attack("scald", "water", 80),
                new Attack("seed bomb", "grass", 80),
                new Attack("shadow ball", "ghost", 80),
                new Attack("slam", "normal", 80),
                new Attack("spirit shackle", "ghost", 80),
                new Attack("strength", "normal", 80),
                new Attack("submission", "fighting", 80),
                new Attack("sucker punch", "dark", 80),
                new Attack("throat chop", "dark", 80),
                new Attack("tri attack", "normal", 80),
                new Attack("waterfall", "water", 80),
                new Attack("whirlpool", "water", 80),
                new Attack("x-scissor", "bug", 80),
                new Attack("zen headbutt", "psychic", 80),
                new Attack("zing zap", "electric", 80),
                new Attack("air slash", "flying", 75),
                new Attack("brick break", "fighting", 75),
                new Attack("crush claw", "normal", 75),
                new Attack("dig", "ground", 75),
                new Attack("drain punch", "fighting", 75),
                new Attack("fire punch", "fire", 75),
                new Attack("giga drain", "grass", 75),
                new Attack("horn leech", "grass", 75),
                new Attack("ice punch", "ice", 75),
                new Attack("razor shell", "water", 75),
                new Attack("relic song", "normal", 75),
                new Attack("rock blast", "rock", 75),
                new Attack("rock slide", "rock", 75),
                new Attack("sand tomb", "ground", 75),
                new Attack("signal beam", "bug", 75),
                new Attack("stomping tantrum", "ground", 75),
                new Attack("super fang", "normal", 75),
                new Attack("thunderpunch", "electric", 75),
                new Attack("chip away", "normal", 70),
                new Attack("cross poison", "poison", 70),
                new Attack("dizzy punch", "normal", 70),
                new Attack("fire spin", "fire", 70),
                new Attack("flame burst", "fire", 70),
                new Attack("freeze-dry", "ice", 70),
                new Attack("fury cutter", "bug", 70),
                new Attack("gear grind", "steel", 70),
                new Attack("headbutt", "normal", 70),
                new Attack("heat crash", "fire", 70),
                new Attack("heavy slam", "steel", 70),
                new Attack("horn drill", "normal", 70),
                new Attack("luster purge", "psychic", 70),
                new Attack("magnitude", "ground", 70),
                new Attack("mist ball", "psychic", 70),
                new Attack("night slash", "dark", 70),
                new Attack("payback", "dark", 70),
                new Attack("psycho cut", "psychic", 70),
                new Attack("retaliate", "normal", 70),
                new Attack("secret power", "normal", 70),
                new Attack("shadow claw", "ghost", 70),
                new Attack("slash", "normal", 70),
                new Attack("smart strike", "steel", 70),
                new Attack("steel wing", "steel", 70),
                new Attack("trop kick", "grass", 70),
                new Attack("vital throw", "fighting", 70),
                new Attack("wake-up slap", "fighting", 70),
                new Attack("aurora beam", "ice", 65),
                new Attack("bone club", "ground", 65),
                new Attack("bone rush", "ground", 65),
                new Attack("brine", "water", 65),
                new Attack("bubblebeam", "water", 65),
                new Attack("chatter", "flying", 65),
                new Attack("fire fang", "fire", 65),
                new Attack("glaciate", "ice", 65),
                new Attack("hex", "ghost", 65),
                new Attack("horn attack", "normal", 65),
                new Attack("ice fang", "ice", 65),
                new Attack("knock off", "dark", 65),
                new Attack("leaf tornado", "grass", 65),
                new Attack("mirror shot", "steel", 65),
                new Attack("mud bomb", "ground", 65),
                new Attack("mystical fire", "fire", 65),
                new Attack("octazooka", "water", 65),
                new Attack("pin missile", "bug", 65),
                new Attack("psybeam", "psychic", 65),
                new Attack("sludge", "poison", 65),
                new Attack("spark", "electric", 65),
                new Attack("steamroller", "bug", 65),
                new Attack("stomp", "normal", 65),
                new Attack("thunder fang", "electric", 65),
                new Attack("venoshock", "poison", 65),
                new Attack("aerial ace", "flying", 60),
                new Attack("air cutter", "flying", 60),
                new Attack("ancientpower", "rock", 60),
                new Attack("assurance", "dark", 60),
                new Attack("avalanche", "ice", 60),
                new Attack("bite", "dark", 60),
                new Attack("brutal swing", "dark", 60),
                new Attack("bug bite", "bug", 60),
                new Attack("bulldoze", "ground", 60),
                new Attack("circle throw", "fighting", 60),
                new Attack("dragon tail", "dragon", 60),
                new Attack("dragonbreath", "dragon", 60),
                new Attack("echoed voice", "normal", 60),
                new Attack("feint attack", "dark", 60),
                new Attack("flame wheel", "fire", 60),
                new Attack("force palm", "fighting", 60),
                new Attack("frost breath", "ice", 60),
                new Attack("heart stamp", "psychic", 60),
                new Attack("hidden power", "normal", 60),
                new Attack("incinerate", "fire", 60),
                new Attack("infestation", "bug", 60),
                new Attack("magical leaf", "grass", 60),
                new Attack("magnet bomb", "steel", 60),
                new Attack("needle arm", "grass", 60),
                new Attack("ominous wind", "ghost", 60),
                new Attack("pluck", "flying", 60),
                new Attack("psywave", "psychic", 60),
                new Attack("revenge", "fighting", 60),
                new Attack("rock tomb", "rock", 60),
                new Attack("rolling kick", "fighting", 60),
                new Attack("round", "normal", 60),
                new Attack("shadow punch", "ghost", 60),
                new Attack("shock wave", "electric", 60),
                new Attack("silver wind", "bug", 60),
                new Attack("sky drop", "flying", 60),
                new Attack("spike cannon", "normal", 60),
                new Attack("storm throw", "fighting", 60),
                new Attack("swift", "normal", 60),
                new Attack("thief", "dark", 60),
                new Attack("water pulse", "water", 60),
                new Attack("water shuriken", "water", 60),
                new Attack("wing attack", "flying", 60),
                new Attack("acrobatics", "flying", 55),
                new Attack("double hit", "normal", 55),
                new Attack("fury swipes", "normal", 55),
                new Attack("icicle spear", "ice", 55),
                new Attack("icy wind", "ice", 55),
                new Attack("mud shot", "ground", 55),
                new Attack("razor leaf", "grass", 55),
                new Attack("snarl", "dark", 55),
                new Attack("vicegrip", "normal", 55),
                new Attack("comet punch", "normal", 52),
                new Attack("arm thrust", "fighting", 50),
                new Attack("bonemerang", "ground", 50),
                new Attack("bullet seed", "grass", 50),
                new Attack("charge beam", "electric", 50),
                new Attack("confusion", "psychic", 50),
                new Attack("cut", "normal", 50),
                new Attack("draining kiss", "fairy", 50),
                new Attack("flame charge", "fire", 50),
                new Attack("karate chop", "fighting", 50),
                new Attack("metal burst", "steel", 50),
                new Attack("metal claw", "steel", 50),
                new Attack("parabolic charge", "electric", 50),
                new Attack("poison fang", "poison", 50),
                new Attack("poison tail", "poison", 50),
                new Attack("pursuit", "dark", 50),
                new Attack("rock throw", "rock", 50),
                new Attack("smack down", "rock", 50),
                new Attack("snore", "normal", 50),
                new Attack("tackle", "normal", 50),
                new Attack("weather ball", "normal", 50),
                new Attack("barrage", "normal", 45),
                new Attack("bind", "normal", 45),
                new Attack("doubleslap", "normal", 45),
                new Attack("fury attack", "normal", 45),
                new Attack("vine whip", "grass", 45),
                new Attack("accelrock", "rock", 40),
                new Attack("acid", "poison", 40),
                new Attack("aqua jet", "water", 40),
                new Attack("beat up", "dark", 40),
                new Attack("bubble", "water", 40),
                new Attack("bullet punch", "steel", 40),
                new Attack("disarming voice", "fairy", 40),
                new Attack("dragon rage", "dragon", 40),
                new Attack("dual chop", "dragon", 40),
                new Attack("ember", "fire", 40),
                new Attack("fairy wind", "fairy", 40),
                new Attack("fake out", "normal", 40),
                new Attack("gust", "flying", 40),
                new Attack("ice shard", "ice", 40),
                new Attack("leafage", "grass", 40),
                new Attack("low kick", "fighting", 40),
                new Attack("mach punch", "fighting", 40),
                new Attack("mega drain", "grass", 40),
                new Attack("night shade", "ghost", 40),
                new Attack("pay day", "normal", 40),
                new Attack("pound", "normal", 40),
                new Attack("powder snow", "ice", 40),
                new Attack("power-up punch", "fighting", 40),
                new Attack("quick attack", "normal", 40),
                new Attack("rock smash", "fighting", 40),
                new Attack("scratch", "normal", 40),
                new Attack("seismic toss", "fighting", 40),
                new Attack("shadow sneak", "ghost", 40),
                new Attack("tail slap", "normal", 40),
                new Attack("thundershock", "electric", 40),
                new Attack("triple kick", "fighting", 40),
                new Attack("twineedle", "bug", 40),
                new Attack("twister", "dragon", 40),
                new Attack("vacuum wave", "fighting", 40),
                new Attack("water gun", "water", 40),
                new Attack("clamp", "water", 35),
                new Attack("peck", "flying", 35),
                new Attack("wrap", "normal", 35),
                new Attack("astonish", "ghost", 30),
                new Attack("double kick", "fighting", 30),
                new Attack("fell stinger", "bug", 30),
                new Attack("ice ball", "ice", 30),
                new Attack("lick", "ghost", 30),
                new Attack("rollout", "rock", 30),
                new Attack("smog", "poison", 30),
                new Attack("stored power", "psychic", 30),
                new Attack("absorb", "grass", 20),
                new Attack("mud-slap", "ground", 20),
                new Attack("nuzzle", "electric", 20),
                new Attack("rage", "normal", 20),
                new Attack("rapid spin", "normal", 20),
                new Attack("sketch", "normal", 20),
                new Attack("sonicboom", "normal", 20),
                new Attack("thunder wave", "electric", 20),
                new Attack("toxic", "poison", 20),
                new Attack("poison sting", "poison", 15),
                new Attack("constrict", "normal", 10),
                new Attack("dark void", "dark", 0),
                new Attack("flatter", "dark", 0),
                new Attack("glare", "normal", 0),
                new Attack("grasswhistle", "grass", 0),
                new Attack("hypnosis", "psychic", 0),
                new Attack("lovely kiss", "normal", 0),
                new Attack("poison gas", "poison", 0),
                new Attack("poisonpowder", "poison", 0),
                new Attack("sleep powder", "grass", 0),
                new Attack("splash", "normal", 0),
                new Attack("spore", "grass", 0),
                new Attack("stun spore", "grass", 0),
            }).ToList();
    }

    public class PokemonAttacks
    {
        public AttackType Primary { get; set; }
        public AttackType Secondary { get; set; }
        public bool Inverse { get; set; }
    }

    public class Attack
    {
        public Attack()
        { }

        public Attack(
            string name,
            string type,
            int power
            )
        {
            Name = name;
            Enum.TryParse(type, out AttackType t);
            Type = t;
            Power = power;
        }

        public string Name { get; }
        public AttackType Type { get; }
        public int Power { get; }
    }

    public enum AttackType
    {
        normal,
        fire,
        water,
        electric,
        grass,
        ice,
        fighting,
        poison,
        ground,
        flying,
        psychic,
        bug,
        rock,
        ghost,
        dragon,
        dark,
        steel,
        fairy
    }
}