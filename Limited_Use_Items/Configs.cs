using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limited_Use_Items
{
    class Configs : Limited_Use_Items
    {
        public static void Init(ConfigFile Config)
        {
            EnableAllConfig = Config.Bind<bool>("0 General Configs", "Enable All Config", false, "This enables all config options for all supported mods even if they aren't installed, this can not be undone.");
            Version = Config.Bind<string>("Dev Config", "Version", "1.0.0", "Please do not change this value");
            Syringe2c = Config.Bind<int>("1.001 Base Game White Timed", "Syringe", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            CritGlasses2c = Config.Bind<int>("1.001 Base Game White Timed", "Lens-Makers Glasses", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            Hoof2c = Config.Bind<int>("1.001 Base Game White Timed", "Pauls Goat Hoof", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            Mushroom2c = Config.Bind<int>("1.001 Base Game White Timed", "Bustling Fungus", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            HealWhileSafe2c = Config.Bind<int>("1.001 Base Game White Timed", "Cautious Slug", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            PersonalShield2c = Config.Bind<int>("1.001 Base Game White Timed", "Personal Shield Generator", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            SprintBonus2c = Config.Bind<int>("1.001 Base Game White Timed", "Energy Drink", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            NearbyDamageBonus2c = Config.Bind<int>("1.001 Base Game White Timed", "Focus Crystal", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            FlatHealth2c = Config.Bind<int>("1.001 Base Game White Timed", "Bison Steak", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            AttackSpeedOnCrit2c = Config.Bind<int>("1.002 Base Game Green Timed", "Predatory Instincts", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            SprintOutOfCombat2c = Config.Bind<int>("1.002 Base Game Green Timed", "Red Whip", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            WarCryOnMultiKill2c = Config.Bind<int>("1.002 Base Game Green Timed", "Berzerkers Pauldron", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            SprintArmor2c = Config.Bind<int>("1.002 Base Game Green Timed", "Rose Buckler", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            SlowOnHit2c = Config.Bind<int>("1.002 Base Game Green Timed", "Chronobauble", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            DeathMark2c = Config.Bind<int>("1.002 Base Game Green Timed", "Death Mark", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            Icicle2c = Config.Bind<int>("1.003 Base Game Red Timed", "Frost Relic", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            Clover2c = Config.Bind<int>("1.003 Base Game Red Timed", "57 Leaf Clover", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            AlienHead2c = Config.Bind<int>("1.003 Base Game Red Timed", "Alien Head", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            IncreaseHealing2c = Config.Bind<int>("1.003 Base Game Red Timed", "Rejuvenation Rack", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            BarrierOnOverHeal2c = Config.Bind<int>("1.003 Base Game Red Timed", "Aegis", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            Bear2c = Config.Bind<int>("1.001 Base Game White Limited", "Tougher Times", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Tooth2c = Config.Bind<int>("1.001 Base Game White Limited", "Monster Tooth", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Crowbar2c = Config.Bind<int>("1.001 Base Game White Limited", "Crowbar", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            BleedOnHit2c = Config.Bind<int>("1.001 Base Game White Limited", "Tri-Tip Dagger", 150, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            WardOnLevel2c = Config.Bind<int>("1.001 Base Game White Limited", "War Banner", 10, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Medkit2c = Config.Bind<int>("1.001 Base Game White Limited", "Medkit", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            IgniteOnKill2c = Config.Bind<int>("1.001 Base Game White Limited", "Gasoline", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            StunChanceOnHit2c = Config.Bind<int>("1.001 Base Game White Limited", "Stun Grenade", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Firework2c = Config.Bind<int>("1.001 Base Game White Limited", "Bundle of Fireworks", 25, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            SecondarySkillMagazine2c = Config.Bind<int>("1.001 Base Game White Limited", "Backup Magazine", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            StickyBomb2c = Config.Bind<int>("1.001 Base Game White Limited", "Sticky Bomb", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            BossDamageBonus2c = Config.Bind<int>("1.001 Base Game White Limited", "Armor-Piercing Rounds", 200, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            BarrierOnKill2c = Config.Bind<int>("1.001 Base Game White Limited", "Topaz Brooch", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ArmorPlate2c = Config.Bind<int>("1.001 Base Game White Limited", "Repulsion Armor Plate", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Missile2c = Config.Bind<int>("1.002 Base Game Green Limited", "AtG Missile Mk. 1", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ExplodeOnDeath2c = Config.Bind<int>("1.002 Base Game Green Limited", "Will-o-the-wisp", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Feather2c = Config.Bind<int>("1.002 Base Game Green Limited", "Hopoo Feather", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ChainLightning2c = Config.Bind<int>("1.002 Base Game Green Limited", "Ukulele", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Seed2c = Config.Bind<int>("1.002 Base Game Green Limited", "Leeching Seed", 200, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Phasing2c = Config.Bind<int>("1.002 Base Game Green Limited", "Old War Stealthkit", 25, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            HealOnCrit2c = Config.Bind<int>("1.002 Base Game Green Limited", "Harvesters Scythe", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            EquipmentMagazine2c = Config.Bind<int>("1.002 Base Game Green Limited", "Fuel Cell", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Bandolier2c = Config.Bind<int>("1.002 Base Game Green Limited", "Bandolier", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            IceRing2c = Config.Bind<int>("1.002 Base Game Green Limited", "Runalds Band", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            FireRing2c = Config.Bind<int>("1.002 Base Game Green Limited", "Kjaros Band", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            JumpBoost2c = Config.Bind<int>("1.002 Base Game Green Limited", "Wax Quail", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ExecuteLowHealthElite2c = Config.Bind<int>("1.002 Base Game Green Limited", "Old Guillotine", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            EnergizedOnEquipmentUse2c = Config.Bind<int>("1.002 Base Game Green Limited", "War Horn", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            TPHealingNova2c = Config.Bind<int>("1.002 Base Game Green Limited", "Lepton Daisy", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Thorns2c = Config.Bind<int>("1.002 Base Game Green Limited", "Razorwire", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            BonusGoldPackOnKill2c = Config.Bind<int>("1.002 Base Game Green Limited", "Ghors Tome", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Squid2c = Config.Bind<int>("1.002 Base Game Green Limited", "Squid Polyp", 50, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Behemoth2c = Config.Bind<int>("1.003 Base Game Red Limited", "Brilliant Behemoth", 500, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Dagger2c = Config.Bind<int>("1.003 Base Game Red Limited", "Ceremonial Dagger", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            GhostOnKill2c = Config.Bind<int>("1.003 Base Game Red Limited", "Happiest Mask", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            FallBoots2c = Config.Bind<int>("1.003 Base Game Red Limited", "H3AD-5T v2", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            NovaOnHeal2c = Config.Bind<int>("1.003 Base Game Red Limited", "NKuhanas Opinion", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ShockNearby2c = Config.Bind<int>("1.003 Base Game Red Limited", "Unstable Tesla Coil", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            BounceNearby2c = Config.Bind<int>("1.003 Base Game Red Limited", "Sentient Meat Hook", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Talisman2c = Config.Bind<int>("1.003 Base Game Red Limited", "Soulbound Catalyst", 250, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            UtilitySkillMagazine2c = Config.Bind<int>("1.003 Base Game Red Limited", "Hardlight Afterburner", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            HeadHunter2c = Config.Bind<int>("1.003 Base Game Red Limited", "Wake of Vultures", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            KillEliteFrenzy2c = Config.Bind<int>("1.003 Base Game Red Limited", "Brainstalks", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            ArmorReductionOnHit2c = Config.Bind<int>("1.003 Base Game Red Limited", "Shattering Justice", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            LaserTurbine2c = Config.Bind<int>("1.003 Base Game Red Limited", "Resonance Disc", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            Plant2c = Config.Bind<int>("1.003 Base Game Red Limited", "Interstellar Desk Plant", 100, "How many uses you can get out of the item. Put 0 to disable the limited function for item.");
            if (AetheriumInstalled || EnableAllConfig.Value)
            {
                FeatheredPlume2c = Config.Bind<int>("2.011 Aetherium White Limited", "Feathered Plume", 100, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                NailBomb2c = Config.Bind<int>("2.011 Aetherium White Timed", "Nail Bomb", 600, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                BloodthirstyShield2c = Config.Bind<int>("2.012 Aetherium Green Timed", "Blood Soaked Shield", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                EngineersToolbelt2c = Config.Bind<int>("2.012 Aetherium Green Timed", "Engineers Toolbelt", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                SharkTeeth2c = Config.Bind<int>("2.012 Aetherium Green Timed", "Shark Teeth", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                ShieldingCore2c = Config.Bind<int>("2.012 Aetherium Green Timed", "Shielding Core", 1200, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                BlasterSword2c = Config.Bind<int>("2.013 Aetherium Red Timed", "Blaster Sword", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                InspiringDrone2c = Config.Bind<int>("2.013 Aetherium Red Timed", "Inspiring Drone", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
                WitchesRing2c = Config.Bind<int>("2.013 Aetherium Red Timed", "Witches Ring", 1800, "How long the item will last, counted in seconds. Put 0 to disable the timed function for item.");
            }
        }
    }
}
