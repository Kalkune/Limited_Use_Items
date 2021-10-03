using BepInEx;
using BepInEx.Configuration;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using RoR2;
using RoR2.ContentManagement;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using UnityEngine;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: HG.Reflection.SearchableAttribute.OptIn]

namespace Limited_Use_Items
{
    [BepInPlugin("com.Kalkune.Limited_Use_Items", "Limited_Use_Items", "1.0.0")]
    [BepInDependency("com.KomradeSpectre.Aetherium", BepInDependency.DependencyFlags.SoftDependency)]
    public class Limited_Use_Items : BaseUnityPlugin
    {
        public static bool StarStorm2Installed;
        public static bool AetheriumInstalled;
        public static ArtifactDef LUIArtifact;
        public static BuffDef Counter;
        public static ItemDef Syringe2;
        public static ItemDef CritGlasses2;
        public static ItemDef Hoof2;
        public static ItemDef Mushroom2;
        public static ItemDef HealWhileSafe2;
        public static ItemDef PersonalShield2;
        public static ItemDef SprintBonus2;
        public static ItemDef NearbyDamageBonus2;
        public static ItemDef FlatHealth2;
        public static ItemDef AttackSpeedOnCrit2;
        public static ItemDef SprintOutOfCombat2;
        public static ItemDef WarCryOnMultiKill2;
        public static ItemDef SprintArmor2;
        public static ItemDef SlowOnHit2;
        public static ItemDef DeathMark2;
        public static ItemDef Icicle2;
        public static ItemDef Clover2;
        public static ItemDef AlienHead2;
        public static ItemDef IncreaseHealing2;
        public static ItemDef BarrierOnOverHeal2;
        public static ItemDef Bear2;
        public static ItemDef Tooth2;
        public static ItemDef Crowbar2;
        public static ItemDef BleedOnHit2;
        public static ItemDef WardOnLevel2;
        public static ItemDef Medkit2;
        public static ItemDef IgniteOnKill2;
        public static ItemDef StunChanceOnHit2;
        public static ItemDef Firework2;
        public static ItemDef SecondarySkillMagazine2;
        public static ItemDef StickyBomb2;
        public static ItemDef BossDamageBonus2;
        public static ItemDef BarrierOnKill2;
        public static ItemDef ArmorPlate2;
        public static ItemDef Missile2;
        public static ItemDef ExplodeOnDeath2;
        public static ItemDef Feather2;
        public static ItemDef ChainLightning2;
        public static ItemDef Seed2;
        public static ItemDef Phasing2;
        public static ItemDef HealOnCrit2;
        public static ItemDef EquipmentMagazine2;
        public static ItemDef Bandolier2;
        public static ItemDef IceRing2;
        public static ItemDef FireRing2;
        public static ItemDef JumpBoost2;
        public static ItemDef ExecuteLowHealthElite2;
        public static ItemDef EnergizedOnEquipmentUse2;
        public static ItemDef TPHealingNova2;
        public static ItemDef Thorns2;
        public static ItemDef BonusGoldPackOnKill2;
        public static ItemDef Squid2;
        public static ItemDef Behemoth2;
        public static ItemDef Dagger2;
        public static ItemDef GhostOnKill2;
        public static ItemDef FallBoots2;
        public static ItemDef NovaOnHeal2;
        public static ItemDef ShockNearby2;
        public static ItemDef BounceNearby2;
        public static ItemDef Talisman2;
        public static ItemDef UtilitySkillMagazine2;
        public static ItemDef HeadHunter2;
        public static ItemDef KillEliteFrenzy2;
        public static ItemDef ArmorReductionOnHit2;
        public static ItemDef LaserTurbine2;
        public static ItemDef Plant2;

        public static ItemDef FeatheredPlume2;
        public static ItemDef NailBomb2;
        public static ItemDef BloodthirstyShield2;
        public static ItemDef EngineersToolbelt2;
        public static ItemDef SharkTeeth2;
        public static ItemDef ShieldingCore2;
        public static ItemDef BlasterSword2;
        public static ItemDef InspiringDrone2;
        public static ItemDef WitchesRing2;

        public static ConfigEntry<bool> EnableAllConfig { get; set; }
        public static ConfigEntry<string> Version { get; set; }
        public static ConfigEntry<int> Syringe2c { get; set; }
        public static ConfigEntry<int> CritGlasses2c { get; set; }
        public static ConfigEntry<int> Hoof2c { get; set; }
        public static ConfigEntry<int> Mushroom2c { get; set; }
        public static ConfigEntry<int> HealWhileSafe2c { get; set; }
        public static ConfigEntry<int> PersonalShield2c { get; set; }
        public static ConfigEntry<int> SprintBonus2c { get; set; }
        public static ConfigEntry<int> NearbyDamageBonus2c { get; set; }
        public static ConfigEntry<int> FlatHealth2c { get; set; }
        public static ConfigEntry<int> AttackSpeedOnCrit2c { get; set; }
        public static ConfigEntry<int> SprintOutOfCombat2c { get; set; }
        public static ConfigEntry<int> WarCryOnMultiKill2c { get; set; }
        public static ConfigEntry<int> SprintArmor2c { get; set; }
        public static ConfigEntry<int> SlowOnHit2c { get; set; }
        public static ConfigEntry<int> DeathMark2c { get; set; }
        public static ConfigEntry<int> Icicle2c { get; set; }
        public static ConfigEntry<int> Clover2c { get; set; }
        public static ConfigEntry<int> AlienHead2c { get; set; }
        public static ConfigEntry<int> IncreaseHealing2c { get; set; }
        public static ConfigEntry<int> BarrierOnOverHeal2c { get; set; }
        public static ConfigEntry<int> Bear2c { get; set; }
        public static ConfigEntry<int> Tooth2c { get; set; }
        public static ConfigEntry<int> Crowbar2c { get; set; }
        public static ConfigEntry<int> BleedOnHit2c { get; set; }
        public static ConfigEntry<int> WardOnLevel2c { get; set; }
        public static ConfigEntry<int> Medkit2c { get; set; }
        public static ConfigEntry<int> IgniteOnKill2c { get; set; }
        public static ConfigEntry<int> StunChanceOnHit2c { get; set; }
        public static ConfigEntry<int> Firework2c { get; set; }
        public static ConfigEntry<int> SecondarySkillMagazine2c { get; set; }
        public static ConfigEntry<int> StickyBomb2c { get; set; }
        public static ConfigEntry<int> BossDamageBonus2c { get; set; }
        public static ConfigEntry<int> BarrierOnKill2c { get; set; }
        public static ConfigEntry<int> ArmorPlate2c { get; set; }
        public static ConfigEntry<int> Missile2c { get; set; }
        public static ConfigEntry<int> ExplodeOnDeath2c { get; set; }
        public static ConfigEntry<int> Feather2c { get; set; }
        public static ConfigEntry<int> ChainLightning2c { get; set; }
        public static ConfigEntry<int> Seed2c { get; set; }
        public static ConfigEntry<int> Phasing2c { get; set; }
        public static ConfigEntry<int> HealOnCrit2c { get; set; }
        public static ConfigEntry<int> EquipmentMagazine2c { get; set; }
        public static ConfigEntry<int> Bandolier2c { get; set; }
        public static ConfigEntry<int> IceRing2c { get; set; }
        public static ConfigEntry<int> FireRing2c { get; set; }
        public static ConfigEntry<int> JumpBoost2c { get; set; }
        public static ConfigEntry<int> ExecuteLowHealthElite2c { get; set; }
        public static ConfigEntry<int> EnergizedOnEquipmentUse2c { get; set; }
        public static ConfigEntry<int> TPHealingNova2c { get; set; }
        public static ConfigEntry<int> Thorns2c { get; set; }
        public static ConfigEntry<int> BonusGoldPackOnKill2c { get; set; }
        public static ConfigEntry<int> Squid2c { get; set; }
        public static ConfigEntry<int> Behemoth2c { get; set; }
        public static ConfigEntry<int> Dagger2c { get; set; }
        public static ConfigEntry<int> GhostOnKill2c { get; set; }
        public static ConfigEntry<int> FallBoots2c { get; set; }
        public static ConfigEntry<int> NovaOnHeal2c { get; set; }
        public static ConfigEntry<int> ShockNearby2c { get; set; }
        public static ConfigEntry<int> BounceNearby2c { get; set; }
        public static ConfigEntry<int> Talisman2c { get; set; }
        public static ConfigEntry<int> UtilitySkillMagazine2c { get; set; }
        public static ConfigEntry<int> HeadHunter2c { get; set; }
        public static ConfigEntry<int> KillEliteFrenzy2c { get; set; }
        public static ConfigEntry<int> ArmorReductionOnHit2c { get; set; }
        public static ConfigEntry<int> LaserTurbine2c { get; set; }
        public static ConfigEntry<int> Plant2c { get; set; }

        public static ConfigEntry<int> FeatheredPlume2c { get; set; }
        public static ConfigEntry<int> NailBomb2c { get; set; }
        public static ConfigEntry<int> BloodthirstyShield2c { get; set; }
        public static ConfigEntry<int> EngineersToolbelt2c { get; set; }
        public static ConfigEntry<int> SharkTeeth2c { get; set; }
        public static ConfigEntry<int> ShieldingCore2c { get; set; }
        public static ConfigEntry<int> BlasterSword2c { get; set; }
        public static ConfigEntry<int> InspiringDrone2c { get; set; }
        public static ConfigEntry<int> WitchesRing2c { get; set; }

        public static string[] masterlisttimeditems = new string[] { };
        public static ItemDef[] masterlisttimeditems2 = new ItemDef[] { };
        public static string[] masterlisttimedstring2 = new string[] { };
        public static int[] masterlisttimedtime2 = new int[] { };
        public static string[] masterlistlimiteditems = new string[] { };
        public static ItemDef[] masterlistlimiteditems2 = new ItemDef[] { };
        public static string[] masterlistlimitedstring2 = new string[] { };
        public static int[] masterlistlimiteduses2 = new int[] { };

        public static string[] timeditems = new string[] { };
        public static ItemDef[] timeditems2 = new ItemDef[] { Syringe2, CritGlasses2, Hoof2, Mushroom2, HealWhileSafe2, PersonalShield2, SprintBonus2, NearbyDamageBonus2, FlatHealth2, AttackSpeedOnCrit2, SprintOutOfCombat2, WarCryOnMultiKill2, SprintArmor2, SlowOnHit2, DeathMark2, Icicle2, Clover2, AlienHead2, IncreaseHealing2, BarrierOnOverHeal2 };
        public static string[] timedstring2 = new string[] { "Syringe2", "CritGlasses2", "Hoof2", "Mushroom2", "HealWhileSafe2", "PersonalShield2", "SprintBonus2", "NearbyDamageBonus2", "FlatHealth2", "AttackSpeedOnCrit2", "SprintOutOfCombat2", "WarCryOnMultiKill2", "SprintArmor2", "SlowOnHit2", "DeathMark2", "Icicle2", "Clover2", "AlienHead2", "IncreaseHealing2", "BarrierOnOverHeal2" };
        public static int[] timedtime2 = new int[] { };
        public static string[] limiteditems = new string[] { };
        public static ItemDef[] limiteditems2 = new ItemDef[] { Bear2, Tooth2, Crowbar2, BleedOnHit2, WardOnLevel2, Medkit2, IgniteOnKill2, StunChanceOnHit2, Firework2, SecondarySkillMagazine2, StickyBomb2, BossDamageBonus2, BarrierOnKill2, ArmorPlate2, Missile2, ExplodeOnDeath2, Feather2, ChainLightning2, Seed2, Phasing2, HealOnCrit2, EquipmentMagazine2, Bandolier2, IceRing2, FireRing2, JumpBoost2, ExecuteLowHealthElite2, EnergizedOnEquipmentUse2, TPHealingNova2, Thorns2, BonusGoldPackOnKill2, Squid2, Behemoth2, Dagger2, GhostOnKill2, FallBoots2, NovaOnHeal2, ShockNearby2, BounceNearby2, Talisman2, UtilitySkillMagazine2, HeadHunter2, KillEliteFrenzy2, ArmorReductionOnHit2, LaserTurbine2, Plant2 };
        public static string[] limitedstring2 = new string[] { "Bear2", "Tooth2", "Crowbar2", "BleedOnHit2", "WardOnLevel2", "Medkit2", "IgniteOnKill2", "StunChanceOnHit2", "Firework2", "SecondarySkillMagazine2", "StickyBomb2", "BossDamageBonus2", "BarrierOnKill2", "ArmorPlate2", "Missile2", "ExplodeOnDeath2", "Feather2", "ChainLightning2", "Seed2", "Phasing2", "HealOnCrit2", "EquipmentMagazine2", "Bandolier2", "IceRing2", "FireRing2", "JumpBoost2", "ExecuteLowHealthElite2", "EnergizedOnEquipmentUse2", "TPHealingNova2", "Thorns2", "BonusGoldPackOnKill2", "Squid2", "Behemoth2", "Dagger2", "GhostOnKill2", "FallBoots2", "NovaOnHeal2", "ShockNearby2", "BounceNearby2", "Talisman2", "UtilitySkillMagazine2", "HeadHunter2", "KillEliteFrenzy2", "ArmorReductionOnHit2", "LaserTurbine2", "Plant2" };
        public static int[] limiteduses2 = new int[] { };

        public static ItemDef[] StarStorm2timeditems = new ItemDef[] { };
        public static ItemDef[] StarStorm2timeditems2 = new ItemDef[] { };
        public static string[] StarStorm2timedstring2 = new string[] { };
        public static int[] StarStorm2timedtime2 = new int[] { };
        public static ItemDef[] StarStorm2limiteditems = new ItemDef[] { };
        public static ItemDef[] StarStorm2limiteditems2 = new ItemDef[] { };
        public static string[] StarStorm2limitedstring2 = new string[] { };
        public static int[] StarStorm2limiteduses2 = new int[] { };

        public static string[] Aetheriumtimeditems = new string[] { };
        public static ItemDef[] Aetheriumtimeditems2 = new ItemDef[] { };
        public static string[] Aetheriumtimedstring2 = new string[] { };
        public static int[] Aetheriumtimedtime2 = new int[] { };
        public static string[] Aetheriumlimiteditems = new string[] { };
        public static ItemDef[] Aetheriumlimiteditems2 = new ItemDef[] { };
        public static string[] Aetheriumlimitedstring2 = new string[] { };
        public static int[] Aetheriumlimiteduses2 = new int[] { };

        /*public static string[] timeditems = new string[] {  };
        public static ItemDef[] timeditems2 = new ItemDef[] {  };
        public static String[] timedstring2 = new string[] {  };
        public static int[] timedtime2 = new int[] {  };
        public static string[] limiteditems = new string[] {  };
        public static ItemDef[] limiteditems2 = new ItemDef[] {  };
        public static String[] limitedstring2 = new String[] {  };
        public static int[] limiteduses2 = new int[] {  };*/

        public void Awake()
        {
            AetheriumInstalled = BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.KomradeSpectre.Aetherium");
            Configs.Init(Config);
            SetupMod();
            Artifact.Init();
            Items.Init();
            ContentManager.collectContentPackProviders += ContentManager_collectContentPackProviders;
            Hook GenericPickupControllerGrantItem = new Hook(typeof(GenericPickupController).GetMethod("GrantItem", BindingFlags.NonPublic | BindingFlags.Instance), typeof(Limited_Use_Items).GetMethod("GenericPickupController_GrantItem"));
            Hook ChacterBodyUpdate = new Hook(typeof(CharacterBody).GetMethod("Update", BindingFlags.Public | BindingFlags.Instance), typeof(Limited_Use_Items).GetMethod("CharacterBody_Update"));
            WhoKnows();
        }
        [RoR2.SystemInitializer(dependencies: typeof(ItemCatalog))]
        public static void AAAAAAAAAAAAAA()
        {
            timeditems = new string[] { RoR2Content.Items.Syringe.name, RoR2Content.Items.CritGlasses.name, RoR2Content.Items.Hoof.name, RoR2Content.Items.Mushroom.name, RoR2Content.Items.HealWhileSafe.name, RoR2Content.Items.PersonalShield.name, RoR2Content.Items.SprintBonus.name, RoR2Content.Items.NearbyDamageBonus.name, RoR2Content.Items.FlatHealth.name, RoR2Content.Items.AttackSpeedOnCrit.name, RoR2Content.Items.SprintOutOfCombat.name, RoR2Content.Items.WarCryOnMultiKill.name, RoR2Content.Items.SprintArmor.name, RoR2Content.Items.SlowOnHit.name, RoR2Content.Items.DeathMark.name, RoR2Content.Items.Icicle.name, RoR2Content.Items.Clover.name, RoR2Content.Items.AlienHead.name, RoR2Content.Items.IncreaseHealing.name, RoR2Content.Items.BarrierOnOverHeal.name };
            limiteditems = new string[] { RoR2Content.Items.Bear.name, RoR2Content.Items.Tooth.name, RoR2Content.Items.Crowbar.name, RoR2Content.Items.BleedOnHit.name, RoR2Content.Items.WardOnLevel.name, RoR2Content.Items.Medkit.name, RoR2Content.Items.IgniteOnKill.name, RoR2Content.Items.StunChanceOnHit.name, RoR2Content.Items.Firework.name, RoR2Content.Items.SecondarySkillMagazine.name, RoR2Content.Items.StickyBomb.name, RoR2Content.Items.BossDamageBonus.name, RoR2Content.Items.BarrierOnKill.name, RoR2Content.Items.ArmorPlate.name, RoR2Content.Items.Missile.name, RoR2Content.Items.ExplodeOnDeath.name, RoR2Content.Items.Feather.name, RoR2Content.Items.ChainLightning.name, RoR2Content.Items.Seed.name, RoR2Content.Items.Phasing.name, RoR2Content.Items.HealOnCrit.name, RoR2Content.Items.EquipmentMagazine.name, RoR2Content.Items.Bandolier.name, RoR2Content.Items.IceRing.name, RoR2Content.Items.FireRing.name, RoR2Content.Items.JumpBoost.name, RoR2Content.Items.ExecuteLowHealthElite.name, RoR2Content.Items.EnergizedOnEquipmentUse.name, RoR2Content.Items.TPHealingNova.name, RoR2Content.Items.Thorns.name, RoR2Content.Items.BonusGoldPackOnKill.name, RoR2Content.Items.Squid.name, RoR2Content.Items.Behemoth.name, RoR2Content.Items.Dagger.name, RoR2Content.Items.GhostOnKill.name, RoR2Content.Items.FallBoots.name, RoR2Content.Items.NovaOnHeal.name, RoR2Content.Items.ShockNearby.name, RoR2Content.Items.BounceNearby.name, RoR2Content.Items.Talisman.name, RoR2Content.Items.UtilitySkillMagazine.name, RoR2Content.Items.HeadHunter.name, RoR2Content.Items.KillEliteFrenzy.name, RoR2Content.Items.ArmorReductionOnHit.name, RoR2Content.Items.LaserTurbine.name, RoR2Content.Items.Plant.name };

            string[][] Alltimeditems = new string[][] { timeditems, Aetheriumtimeditems };
            string[][] Alllimiteditems = new string[][] { limiteditems, Aetheriumlimiteditems };
            string[][][] AllItemDefLists = new string[][][] { Alltimeditems, Alllimiteditems };
            string[][] AllItemDefMasterLists = new string[][] { masterlisttimeditems, masterlistlimiteditems };
            for (int i = 0; i < AllItemDefLists.Length; i++)
            {
                int masterlistendlength = 0;
                for (int j = 0; j < AllItemDefLists[i].Length; j++)
                {
                    masterlistendlength += AllItemDefLists[i][j].Length;
                }
                int masterlistlength = 0;
                AllItemDefMasterLists[i] = new string[masterlistendlength];
                for (int j = 0; j < AllItemDefLists[i].Length; j++)
                {
                    AllItemDefLists[i][j].CopyTo(AllItemDefMasterLists[i], masterlistlength);
                    masterlistlength += AllItemDefLists[i][j].Length;
                }
            }
            masterlisttimeditems = new string[AllItemDefMasterLists[0].Length];
            AllItemDefMasterLists[0].CopyTo(masterlisttimeditems, 0);
            masterlistlimiteditems = new string[AllItemDefMasterLists[1].Length];
            AllItemDefMasterLists[1].CopyTo(masterlistlimiteditems, 0);
        }

        public static void SetupMod()
        {
            timedtime2 = new int[] { Syringe2c.Value, CritGlasses2c.Value, Hoof2c.Value, Mushroom2c.Value, HealWhileSafe2c.Value, PersonalShield2c.Value, SprintBonus2c.Value, NearbyDamageBonus2c.Value, FlatHealth2c.Value, AttackSpeedOnCrit2c.Value, SprintOutOfCombat2c.Value, WarCryOnMultiKill2c.Value, SprintArmor2c.Value, SlowOnHit2c.Value, DeathMark2c.Value, Icicle2c.Value, Clover2c.Value, AlienHead2c.Value, IncreaseHealing2c.Value, BarrierOnOverHeal2c.Value };
            limiteduses2 = new int[] { Bear2c.Value, Tooth2c.Value, Crowbar2c.Value, BleedOnHit2c.Value, WardOnLevel2c.Value, Medkit2c.Value, IgniteOnKill2c.Value, StunChanceOnHit2c.Value, Firework2c.Value, SecondarySkillMagazine2c.Value, StickyBomb2c.Value, BossDamageBonus2c.Value, BarrierOnKill2c.Value, ArmorPlate2c.Value, Missile2c.Value, ExplodeOnDeath2c.Value, Feather2c.Value, ChainLightning2c.Value, Seed2c.Value, Phasing2c.Value, HealOnCrit2c.Value, EquipmentMagazine2c.Value, Bandolier2c.Value, IceRing2c.Value, FireRing2c.Value, JumpBoost2c.Value, ExecuteLowHealthElite2c.Value, EnergizedOnEquipmentUse2c.Value, TPHealingNova2c.Value, Thorns2c.Value, BonusGoldPackOnKill2c.Value, Squid2c.Value, Behemoth2c.Value, Dagger2c.Value, GhostOnKill2c.Value, FallBoots2c.Value, NovaOnHeal2c.Value, ShockNearby2c.Value, BounceNearby2c.Value, Talisman2c.Value, UtilitySkillMagazine2c.Value, HeadHunter2c.Value, KillEliteFrenzy2c.Value, ArmorReductionOnHit2c.Value, LaserTurbine2c.Value, Plant2c.Value };
            if (AetheriumInstalled)
            {
                AetheriumSetup();
            }

            ItemDef[][] Alltimeditems2 = new ItemDef[][] { timeditems2, Aetheriumtimeditems2 };
            ItemDef[][] Alllimiteditems2 = new ItemDef[][] { limiteditems2, Aetheriumlimiteditems2 };
            ItemDef[][][] AllItemDefLists = new ItemDef[][][] { Alltimeditems2, Alllimiteditems2 };
            ItemDef[][] AllItemDefMasterLists = new ItemDef[][] { masterlisttimeditems2, masterlistlimiteditems2 };
            for (int i = 0; i < AllItemDefLists.Length; i++)
            {
                int masterlistendlength = 0;
                for (int j = 0; j < AllItemDefLists[i].Length; j++)
                {
                    masterlistendlength += AllItemDefLists[i][j].Length;
                }
                int masterlistlength = 0;
                AllItemDefMasterLists[i] = new ItemDef[masterlistendlength];
                for (int j = 0; j < AllItemDefLists[i].Length; j++)
                {
                    AllItemDefLists[i][j].CopyTo(AllItemDefMasterLists[i], masterlistlength);
                    masterlistlength += AllItemDefLists[i][j].Length;
                }
            }
            masterlisttimeditems2 = new ItemDef[AllItemDefMasterLists[0].Length];
            AllItemDefMasterLists[0].CopyTo(masterlisttimeditems2, 0);
            masterlistlimiteditems2 = new ItemDef[AllItemDefMasterLists[1].Length];
            AllItemDefMasterLists[1].CopyTo(masterlistlimiteditems2, 0);

            string[][] Alltimedstring2 = new string[][] { timedstring2, Aetheriumtimedstring2 };
            string[][] Alllimitedstring2 = new string[][] { limitedstring2, Aetheriumlimitedstring2 };
            string[][][] AllstringLists = new string[][][] { Alltimedstring2, Alllimitedstring2 };
            string[][] AllstringMasterLists = new string[][] { masterlisttimedstring2, masterlistlimitedstring2 };
            for (int i = 0; i < AllstringLists.Length; i++)
            {
                int masterlistendlength = 0;
                for (int j = 0; j < AllstringLists[i].Length; j++)
                {
                    masterlistendlength += AllstringLists[i][j].Length;
                }
                int masterlistlength = 0;
                AllstringMasterLists[i] = new string[masterlistendlength];
                for (int j = 0; j < AllstringLists[i].Length; j++)
                {
                    AllstringLists[i][j].CopyTo(AllstringMasterLists[i], masterlistlength);
                    masterlistlength += AllstringLists[i][j].Length;
                }
            }
            masterlisttimedstring2 = new string[AllstringMasterLists[0].Length];
            AllstringMasterLists[0].CopyTo(masterlisttimedstring2, 0);
            masterlistlimitedstring2 = new string[AllstringMasterLists[1].Length];
            AllstringMasterLists[1].CopyTo(masterlistlimitedstring2, 0);

            int[][] Alltimedtime2 = new int[][] { timedtime2, Aetheriumtimedtime2 };
            int[][] Alllimiteduses2 = new int[][] { limiteduses2, Aetheriumlimiteduses2 };
            int[][][] AllintLists = new int[][][] { Alltimedtime2, Alllimiteduses2 };
            int[][] AllintMasterLists = new int[][] { masterlisttimedtime2, masterlistlimiteduses2 };
            for (int i = 0; i < AllintLists.Length; i++)
            {
                int masterlistendlength = 0;
                for (int j = 0; j < AllintLists[i].Length; j++)
                {
                    masterlistendlength += AllintLists[i][j].Length;
                }
                int masterlistlength = 0;
                AllintMasterLists[i] = new int[masterlistendlength];
                for (int j = 0; j < AllintLists[i].Length; j++)
                {
                    AllintLists[i][j].CopyTo(AllintMasterLists[i], masterlistlength);
                    masterlistlength += AllintLists[i][j].Length;
                }
            }
            masterlisttimedtime2 = new int[AllintMasterLists[0].Length];
            AllintMasterLists[0].CopyTo(masterlisttimedtime2, 0);
            masterlistlimiteduses2 = new int[AllintMasterLists[1].Length];
            AllintMasterLists[1].CopyTo(masterlistlimiteduses2, 0);
            //Hook someHook2 = new Hook(typeof(Aetherium.Items.FeatheredPlume).GetMethod("CalculateSpeedReward", BindingFlags.NonPublic | BindingFlags.Instance), typeof(Limited_Use_Items).GetMethod("SomeHook2"));
            /*public static void SomeHook2(Action<Aetherium.Items.FeatheredPlume, On.RoR2.HealthComponent.orig_TakeDamage, HealthComponent, DamageInfo> orig, Aetherium.Items.FeatheredPlume help, On.RoR2.HealthComponent.orig_TakeDamage what, RoR2.HealthComponent self, RoR2.DamageInfo damageInfo)
            {
                orig(help, what, self, damageInfo);
                Chat.AddMessage("On Hook");
            }*/

        }
        public static void AetheriumSetup()
        {
            Aetheriumtimeditems = new string[] { Aetherium.Items.SharkTeeth.instance.ItemDef.name, Aetherium.Items.ShieldingCore.instance.ItemDef.name, Aetherium.Items.InspiringDrone.instance.ItemDef.name };
            Aetheriumtimeditems2 = new ItemDef[] { SharkTeeth2, ShieldingCore2, InspiringDrone2 };
            Aetheriumtimedstring2 = new string[] { "SharkTeeth2", "ShieldingCore2", "InspiringDrone2" };
            Aetheriumtimedtime2 = new int[] { SharkTeeth2c.Value, ShieldingCore2c.Value, InspiringDrone2c.Value };
            Aetheriumlimiteditems = new string[] { Aetherium.Items.FeatheredPlume.instance.ItemDef.name, Aetherium.Items.NailBomb.instance.ItemDef.name, Aetherium.Items.BloodthirstyShield.instance.ItemDef.name, Aetherium.Items.EngineersToolbelt.instance.ItemDef.name, Aetherium.Items.BlasterSword.instance.ItemDef.name, Aetherium.Items.WitchesRing.instance.ItemDef.name };
            Aetheriumlimiteditems2 = new ItemDef[] { FeatheredPlume2, NailBomb2, BloodthirstyShield2, EngineersToolbelt2, BlasterSword2, WitchesRing2 };
            Aetheriumlimitedstring2 = new string[] { "FeatheredPlume2", "NailBomb2", "BloodthirstyShield2", "EngineersToolbelt2", "BlasterSword2", "WitchesRing2" };
            Aetheriumlimiteduses2 = new int[] { FeatheredPlume2c.Value, NailBomb2c.Value, BloodthirstyShield2c.Value, EngineersToolbelt2c.Value, BlasterSword2c.Value, WitchesRing2c.Value };
        }

        public static void CharacterBody_Update(Action<CharacterBody> orig, CharacterBody self)
        {
            orig(self);
            if (!RunArtifactManager.instance.IsArtifactEnabled(LUIArtifact))
                return;
            if (!self.inventory || self.GetBuffCount(Counter) != 0)
                return;
            bool apply = false;
            for (int i = 0; i < masterlisttimeditems.Length; i++)
            {
                if (self.inventory.GetItemCount(masterlisttimeditems2[i]) > 0)
                {
                    if (self.inventory.GetItemCount(masterlisttimeditems2[i]) == 1)
                    {
                        self.inventory.RemoveItem(masterlisttimeditems2[i]);
                        self.inventory.RemoveItem(ItemCatalog.FindItemIndex(masterlisttimeditems[i]));
                        if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlisttimeditems[i])).tier == ItemTier.Tier1)
                            self.inventory.GiveItem(RoR2Content.Items.ScrapWhite);
                        if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlisttimeditems[i])).tier == ItemTier.Tier2)
                            self.inventory.GiveItem(RoR2Content.Items.ScrapGreen);
                        if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlisttimeditems[i])).tier == ItemTier.Tier3)
                            self.inventory.GiveItem(RoR2Content.Items.ScrapRed);
                        if (self.inventory.GetItemCount(ItemCatalog.FindItemIndex(masterlisttimeditems[i])) > 0)
                            self.inventory.GiveItem(masterlisttimeditems2[i], masterlisttimedtime2[i] * 10);
                    }
                    else
                        self.inventory.RemoveItem(masterlisttimeditems2[i]);
                    apply = true;
                }
            }
            if (apply)
                self.AddTimedBuff(Counter, 0.1f);
        }

        public static void GenericPickupController_GrantItem(Action<GenericPickupController, CharacterBody, Inventory> orig, GenericPickupController self, CharacterBody body, Inventory inventory)
        {
            orig(self, body, inventory);
            if (!RunArtifactManager.instance.IsArtifactEnabled(LUIArtifact))
                return;
            for (int i = 0; i < masterlisttimeditems.Length; i++)
            {
                if (self.pickupIndex == PickupCatalog.FindPickupIndex(ItemCatalog.FindItemIndex(masterlisttimeditems[i])) && inventory.GetItemCount(masterlisttimeditems2[i]) == 0)
                    inventory.GiveItem(masterlisttimeditems2[i], masterlisttimedtime2[i] * 10);
            }
            for (int i = 0; i < masterlistlimiteditems.Length; i++)
            {
                if (self.pickupIndex == PickupCatalog.FindPickupIndex(ItemCatalog.FindItemIndex(masterlistlimiteditems[i])) && inventory.GetItemCount(masterlistlimiteditems2[i]) == 0)
                    inventory.GiveItem(masterlistlimiteditems2[i], masterlistlimiteduses2[i]);
            }
        }

        public void WhoKnows()
        {
            ILHook HealthComponentTakeDamage = new ILHook(typeof(HealthComponent).GetMethod("TakeDamage", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdfld<HealthComponent.ItemCounts>("bear")) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Bear2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(17)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Crowbar2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(22)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BossDamageBonus2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdfld<HealthComponent.ItemCounts>("armorPlate")) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ArmorPlate2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(40)) && c.TryGotoNext(x => x.MatchCallOrCallvirt<HealthComponent>("get_combinedHealthFraction")) && c.TryGotoNext(MoveType.After, x => x.MatchBgtUn(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ExecuteLowHealthElite2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdfld<HealthComponent.ItemCounts>("thorns")) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Thorns2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdsfld(typeof(RoR2Content.Buffs), "PulverizeBuildup"), x => x.MatchCallOrCallvirt<CharacterBody>("GetBuffCount"), x => x.MatchLdcI4(out _), x => x.MatchBlt(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ArmorReductionOnHit2"); });
                }
            });
            ILHook GlobalEventManagerOnCharacterDeath = new ILHook(typeof(GlobalEventManager).GetMethod("OnCharacterDeath", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(35)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Tooth2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(32)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("IgniteOnKill2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(40)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BarrierOnKill2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(33)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ExplodeOnDeath2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(38)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Bandolier2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(59)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BonusGoldPackOnKill2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(34), x => x.MatchLdcI4(0), x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Dagger2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchBle(out _), x => x.MatchLdloc(out _), x => x.MatchCallOrCallvirt<CharacterBody>("get_equipmentSlot"), x => x.MatchCallOrCallvirt<UnityEngine.Object>("op_Implicit"), x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Talisman2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(54), x => x.MatchLdcI4(out _), x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("HeadHunter2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(55), x => x.MatchLdcI4(out _), x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("KillEliteFrenzy2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(41), x => x.MatchLdcI4(out _), x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Plant2"); });
                }
            });
            ILHook GlobalEventManagerOnHitEnemy = new ILHook(typeof(GlobalEventManager).GetMethod("OnHitEnemy", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdarg(1)) && c.TryGotoNext(MoveType.After, x => x.MatchStloc(24)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BleedOnHit2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(14)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("StickyBomb2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(12)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ChainLightning2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(19)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Seed2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(53)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("IceRing2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(x => x.MatchLdloc(54)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("FireRing2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdarg(out _), x => x.MatchLdflda<DamageInfo>("procChainMask"), x => x.MatchLdcI4(7), x => x.MatchCallOrCallvirt<ProcChainMask>("HasProc"), x => x.MatchBrtrue(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BounceNearby2"); });
                }
            });
            ILHook WardOnLevelManagerOnCharacterLevelUp = new ILHook(typeof(RoR2.Items.WardOnLevelManager).GetMethod("OnCharacterLevelUp", BindingFlags.NonPublic | BindingFlags.Static), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(1)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("WardOnLevel2"); });
                }
            });
            ILHook CharacterBodyRemoveBuff = new ILHook(typeof(CharacterBody).GetMethod("RemoveBuff", BindingFlags.Public | BindingFlags.Instance, null, new[] { typeof(BuffIndex) }, null), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(4)) && c.TryGotoNext(MoveType.After, x => x.MatchPop()))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Medkit2"); });
                }
            });
            ILHook GlobalEventManagerOnInteractionBegin = new ILHook(typeof(GlobalEventManager).GetMethod("OnInteractionBegin", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(5)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Firework2"); });
                }
                if (c.TryGotoNext(x => x.MatchLdloc(4)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Squid2"); });
                }
            });
            ILHook SetStateOnHurtOnTakeDamageServer = new ILHook(typeof(SetStateOnHurt).GetMethod("OnTakeDamageServer", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(3)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("StunChanceOnHit2"); });
                }
            });
            ILHook ChargingStateOnEnter = new ILHook(typeof(TeleporterInteraction.ChargingState).GetMethod("OnEnter", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(8)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("WardOnLevel2"); });
                }
            });
            ILHook GlobalEventManagerOnCrit = new ILHook(typeof(GlobalEventManager).GetMethod("OnCrit", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(2)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("HealOnCrit2"); });
                }
            });
            ILHook PhasingItemBehaviorServerFixedUpdate = new ILHook(typeof(CharacterBody.PhasingItemBehaviorServer).GetMethod("FixedUpdate", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdarg(0)) && c.TryGotoNext(MoveType.After, x => x.MatchBltUn(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Phasing2"); });
                }
            });
            ILHook EquipmentSlotExecute = new ILHook(typeof(EquipmentSlot).GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdloc(2)) && c.TryGotoNext(MoveType.After, x => x.MatchBle(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("EnergizedOnEquipmentUse2"); });
                }
            });
            ILHook GlobalEventManagerProcMissile = new ILHook(typeof(RoR2.GlobalEventManager).GetMethod("ProcMissile", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchLdcR4(10)) && c.TryGotoNext(MoveType.After, x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Missile2"); });
                }
            });
            ILHook GenericCharacterMainProcessJump = new ILHook(typeof(EntityStates.GenericCharacterMain).GetMethod("ProcessJump", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchLdfld<CharacterBody>("baseJumpCount"), x => x.MatchBlt(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Feather2"); });
                }
                c.Index = 0;
                if (c.TryGotoNext(MoveType.After, x => x.MatchCallOrCallvirt<CharacterBody>("get_moveSpeed"), x => x.MatchLdcR4(0), x => x.MatchBleUn(out _), x => x.MatchLdloc(out _), x => x.MatchLdcR4(0), x => x.MatchBleUn(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("JumpBoost2"); });
                }
            });
            ILHook CharacterBodyUpdateTeslaCoil = new ILHook(typeof(CharacterBody).GetMethod("UpdateTeslaCoil", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdarg(0), x => x.MatchLdfld<CharacterBody>("teslaIsOn"), x => x.MatchBrtrue(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("ShockNearby2"); });
                }
            });
            ILHook GlobalEventManagerOnHitAll = new ILHook(typeof(RoR2.GlobalEventManager).GetMethod("OnHitAll", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);
                if (c.TryGotoNext(MoveType.After, x => x.MatchBle(out _), x => x.MatchLdarg(1), x => x.MatchLdfld<DamageInfo>("procCoefficient"), x => x.MatchLdcR4(0), x => x.MatchBeq(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("Behemoth2"); });
                }
            });
            ILHook UtilTryToCreateGhost = new ILHook(typeof(RoR2.Util).GetMethod("TryToCreateGhost", BindingFlags.Public | BindingFlags.Static), il =>
            {
                var c = new ILCursor(il);
                if (c.TryGotoNext(MoveType.Before, x => x.MatchLdloc(out _), x => x.MatchRet()))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("GhostOnKill2"); });
                }
            });
            ILHook HealthComponentServerFixedUpdate = new ILHook(typeof(RoR2.HealthComponent).GetMethod("ServerFixedUpdate", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(out _), x => x.MatchCallOrCallvirt<UnityEngine.Object>("op_Implicit"), x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("NovaOnHeal2"); });
                }
            });
            ILHook HeadstompersFallDoStompExplosionAuthority = new ILHook(typeof(EntityStates.Headstompers.HeadstompersFall).GetMethod("DoStompExplosionAuthority", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);
                if (c.TryGotoNext(MoveType.After, x => x.MatchLdloc(out _), x => x.MatchLdcR4(out _), x => x.MatchBleUn(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("FallBoots2"); });
                }
            });
            ILHook LaserTurbineControllerExpendCharge = new ILHook(typeof(LaserTurbineController).GetMethod("ExpendCharge", BindingFlags.Public | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);
                c.Goto(c.Instrs.Last());
                if (c.TryGotoNext(MoveType.After))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("LaserTurbine2"); });
                }
            });
            if (AetheriumInstalled)
                AetheriumWhoKnows();
        }
        public void AetheriumWhoKnows()
        {
            ILHook FeatheredPlumeCalculateSpeedReward = new ILHook(typeof(Aetherium.Items.FeatheredPlume).GetMethod("CalculateSpeedReward", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(x => x.MatchCall<Aetherium.Items.ItemBase>("GetCount")) && c.TryGotoNext(MoveType.After, x => x.MatchStloc(out _), x => x.MatchLdloc(out _), x => x.MatchBrfalse(out _)))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("FeatheredPlume2"); });
                }
            });
            ILHook NailBombFireNailBombFromBody = new ILHook(typeof(Aetherium.Items.NailBomb).GetMethod("FireNailBombFromBody", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<CharacterBody>("AddTimedBuff")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("NailBomb2"); });
                }
            });
            ILHook NailBombFireNailBomb = new ILHook(typeof(Aetherium.Items.NailBomb).GetMethod("FireNailBomb", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<CharacterBody>("AddTimedBuff")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("NailBomb2"); });
                }
            });
            ILHook BloodthirstyShieldGrantShieldReward = new ILHook(typeof(Aetherium.Items.BloodthirstyShield).GetMethod("GrantShieldReward", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<HealthComponent>("RechargeShield")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("BloodthirstyShield2"); });
                }
            });
            ILHook EngineersToolbeltDuplicateDronesAndTurrets = new ILHook(typeof(Aetherium.Items.EngineersToolbelt).GetMethod("DuplicateDronesAndTurrets", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<MasterSummon>("Perform")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("EngineersToolbelt2"); });
                }
            });
            ILHook EngineersToolbeltReviveDronesAndTurrets = new ILHook(typeof(Aetherium.Items.EngineersToolbelt).GetMethod("ReviveDronesAndTurrets", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<Inventory>("GiveItem")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("EngineersToolbelt2"); });
                }
            });
            ILHook WitchesRingGrantOnKillEffectsOnHighDamage = new ILHook(typeof(Aetherium.Items.WitchesRing).GetMethod("GrantOnKillEffectsOnHighDamage", BindingFlags.NonPublic | BindingFlags.Instance), il =>
            {
                var c = new ILCursor(il);

                if (c.TryGotoNext(MoveType.After, x => x.MatchCallvirt<GlobalEventManager>("OnCharacterDeath")))
                {
                    c.EmitDelegate<Action>(() => { LimitedUses("WitchesRing2"); });
                }
            });
            Aetherium.Items.BlasterSword.onBlasterSwordFired += (fireProjectileInfo) =>
            {
                LimitedUses("BlasterSword2");
            };
        }

        public void LimitedUses(string whatnow)
        {
            if (!RunArtifactManager.instance.IsArtifactEnabled(LUIArtifact))
                return;
            int helpme = Array.FindIndex(masterlistlimitedstring2, x => x.Equals(whatnow));
            if (helpme == -1)
            {
                Chat.AddMessage(whatnow + " did not work");
                return;
            }
            Inventory inventory = LocalUserManager.GetFirstLocalUser().cachedBody.inventory;
            if (inventory.GetItemCount(masterlistlimiteditems2[helpme]) > 0)
            {
                if (inventory.GetItemCount(masterlistlimiteditems2[helpme]) == 1)
                {
                    inventory.RemoveItem(masterlistlimiteditems2[helpme]);
                    inventory.RemoveItem(ItemCatalog.FindItemIndex(masterlistlimiteditems[helpme]));
                    if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlistlimiteditems[helpme])).tier == ItemTier.Tier1)
                        inventory.GiveItem(RoR2Content.Items.ScrapWhite);
                    if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlistlimiteditems[helpme])).tier == ItemTier.Tier2)
                        inventory.GiveItem(RoR2Content.Items.ScrapGreen);
                    if (ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex(masterlistlimiteditems[helpme])).tier == ItemTier.Tier3)
                        inventory.GiveItem(RoR2Content.Items.ScrapRed);
                    if (inventory.GetItemCount(ItemCatalog.FindItemIndex(masterlistlimiteditems[helpme])) > 0)
                        inventory.GiveItem(masterlistlimiteditems2[helpme], masterlistlimiteduses2[helpme]);
                }
                else
                    inventory.RemoveItem(masterlistlimiteditems2[helpme]);
            }
        }
        private void ContentManager_collectContentPackProviders(ContentManager.AddContentPackProviderDelegate addContentPackProvider)
        {
            addContentPackProvider(new Content());
        }
        public class Content : IContentPackProvider
        {
            public ContentPack contentPack = new ContentPack();

            public string identifier
            {
                get { return "Content"; }
            }

            public IEnumerator LoadStaticContentAsync(LoadStaticContentAsyncArgs args)
            {
                BuffDef[] buffDefs = new BuffDef[] { Counter };
                ArtifactDef[] artifactDefs = new ArtifactDef[] { LUIArtifact };
                contentPack.identifier = identifier;
                contentPack.itemDefs.Add(masterlisttimeditems2);
                contentPack.itemDefs.Add(masterlistlimiteditems2);
                contentPack.buffDefs.Add(buffDefs);
                contentPack.artifactDefs.Add(artifactDefs);
                args.ReportProgress(1f);
                yield break;
            }

            public IEnumerator GenerateContentPackAsync(GetContentPackAsyncArgs args)
            {
                ContentPack.Copy(contentPack, args.output);
                args.ReportProgress(1f);
                yield break;
            }

            public IEnumerator FinalizeAsync(FinalizeAsyncArgs args)
            {
                args.ReportProgress(1f);
                yield break;
            }
        }
    }
}
