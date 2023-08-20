using UnityEngine;
using RoR2;
using System.Collections.Generic;
using Potmobile.Cores;
using System.Runtime.CompilerServices;
using Potmobile;

namespace RoR2HaulerIrohaSkin
{
    public static class HaulerIrohaItemDisplays
    {
        public static ItemDisplayRuleSet itemDisplayRuleSet;

        public static List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemRules;

        public static void RegisterDisplays()
        {
            itemDisplayRuleSet = ScriptableObject.CreateInstance<ItemDisplayRuleSet>();
            itemRules = new List<ItemDisplayRuleSet.KeyAssetRuleGroup>();

            #region DisplayRules
            #region Vanilla
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringe", "armatureRoot", new Vector3(-0.49421F, 4.06218F, 0.20622F), new Vector3(286.9454F, 180F, 180F), new Vector3(0.2866F, 0.2866F, 0.2866F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear", "armatureRoot", new Vector3(-0.85473F, 4.30996F, 0.80288F), new Vector3(0F, 0F, 0F), new Vector3(0.50616F, 0.50616F, 0.50616F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Behemoth, "DisplayBehemoth", "armatureRoot", new Vector3(0F, 2.43409F, 8.87692F), new Vector3(60.71561F, 90F, 90F), new Vector3(0.24077F, 0.24077F, 0.24077F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher", "armatureRoot", new Vector3(2.49932F, 3.2361F, 1.60916F), new Vector3(0F, 0F, 0F), new Vector3(0.3569F, 0.3569F, 0.3569F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp", "armatureRoot", new Vector3(0.89131F, 2.80105F, -4.19329F), new Vector3(354.3547F, 0F, 0F), new Vector3(0.34752F, 0.34752F, 0.34752F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger", "armatureRoot", new Vector3(-0.86599F, 4.60096F, -0.18234F), new Vector3(359.1149F, 32.94764F, 26.18162F), new Vector3(1.44252F, 1.44252F, 1.44252F)));

            //IDRS NOTE: [TOOTH] = Decal is the 'string' of the necklace and its a projected decal.
            //IDRS NOTE: [TOOTH] = Order is: Small1, Small1, Large, Small2, Small2 on the character
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Tooth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothNecklaceDecal"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothMeshLarge"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothMeshSmall1"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothMeshSmall1"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothMeshSmall2"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayToothMeshSmall2"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                    }
                }
            });
            //might also be able to just do this but thats not the spirit of it
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Tooth, RoR2/Base/Tooth/mdlToothNecklaceDisplay.fbx
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses", "armatureRoot", new Vector3(-0.80768F, 4.98982F, 0.06856F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Hoof, "DisplayHoof", "armatureRoot", new Vector3(3.02987F, 1.93995F, 4.27309F), new Vector3(13.90426F, 180F, 180F), new Vector3(0.34226F, 0.34226F, 0.34226F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Feather, "DisplayFeather", "armatureRoot", new Vector3(0F, 1.94406F, -2.14702F), new Vector3(0F, 0F, 0F), new Vector3(0.12088F, 0.12088F, 0.12088F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele", "armatureRoot", new Vector3(1.97272F, 3.04944F, 0.12127F), new Vector3(356.5254F, 105.2454F, 359.0537F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", "armatureRoot", new Vector3(-0.38248F, 5.18688F, 0F), new Vector3(0F, 0F, 0F), new Vector3(0.07769F, 0.07769F, 0.07769F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic", Vector3.zero, Vector3.zero, Vector3.one));
            //this seems used for the ice elite? then why that asset path? 
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayIcicle", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask", "armatureRoot", new Vector3(-0.82223F, 3.67772F, 2.53958F), new Vector3(292.3155F, 0F, 0F), new Vector3(1.904F, 1.904F, 1.904F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom", "armatureRoot", new Vector3(0F, 2.08537F, -2.87827F), new Vector3(0F, 0F, 0F), new Vector3(0.20147F, 0.20147F, 0.20147F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar", "armatureRoot", new Vector3(1.23255F, 2.12857F, 4.1497F), new Vector3(0F, 336.8636F, 92.20478F), new Vector3(0.76604F, 0.76604F, 0.76604F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt", "armatureRoot", new Vector3(-0.77556F, 5.30946F, 0.16619F), new Vector3(0F, 0F, 0F), new Vector3(1.33632F, 0.3157F, 1.33632F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHit, "DisplayTriTip", "armatureRoot", new Vector3(2.54261F, 2.06636F, 3.97944F), new Vector3(0F, 355.9723F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip", "armatureRoot", new Vector3(2.10211F, 3.09277F, 0.62178F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.FallBoots, "DisplayGravBoots", "armatureRoot", new Vector3(0F, -0.47606F, 2.80795F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner", "armatureRoot", new Vector3(0F, 2.50822F, -3.99495F), new Vector3(0F, 0F, 269.939F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit", "armatureRoot", new Vector3(-1.49787F, 4.21867F, 0F), new Vector3(321.1174F, 154.1211F, 202.4148F), new Vector3(0.47629F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe", "armatureRoot", new Vector3(-1.05064F, 2.11859F, 4.4007F), new Vector3(0F, 33.8216F, 0F), new Vector3(0.43462F, 0.43462F, 0.43462F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail", "armatureRoot", new Vector3(-1.68424F, 3.8376F, 1.0545F), new Vector3(0F, 0F, 0F), new Vector3(0.19289F, 0.19289F, 0.19289F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator", "armatureRoot", new Vector3(0F, 3.80642F, 2.04095F), new Vector3(347.5227F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery", "armatureRoot", new Vector3(2.77693F, 1.99599F, 0F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.NovaOnHeal,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule()
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayDevilHorns"),
                            childName = "armatureRoot",
                            localPos = new Vector3(-0.51605F, 5.18851F, -0.13252F),
                            localAngles = new Vector3(325.8184F, 166.6907F, 202.8343F),
                            localScale = new Vector3(1.52944F, 1.52944F, 1.52944F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule()
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayDevilHorns"),
                            childName = "armatureRoot",
localPos = new Vector3(-1.17954F, 5.18851F, -0.13252F),
localAngles = new Vector3(325.8184F, 166.6907F, 202.8343F),
localScale = new Vector3(-1.52944F, -1.52944F, 1.52944F),
                            limbMask = LimbFlags.None
                        },
                    }
                }
            });
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ShockNearby, "DisplayTeslaCoil", "armatureRoot", new Vector3(2.52139F, 2.09559F, -1.083F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion", "armatureRoot", new Vector3(1.93887F, 2.53363F, 0F), new Vector3(0F, 296.8145F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover", "armatureRoot", new Vector3(-0.33753F, 5.14937F, -0.37195F), new Vector3(0F, 0F, 292.5165F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit", "armatureRoot", new Vector3(1.22168F, 2.20781F, -1.58816F), new Vector3(289.4456F, 226.9288F, 221.3967F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier", "armatureRoot", new Vector3(1.54152F, 3.17748F, -0.62409F), new Vector3(0F, 128.7028F, 0F), new Vector3(1.12601F, 1.48016F, 1.48016F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook", "armatureRoot", new Vector3(-1.84691F, 3.86426F, 1.11114F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline", "armatureRoot", new Vector3(2.78434F, 1.36697F, -3.38325F), new Vector3(276.9106F, 180F, 180F), new Vector3(1.45064F, 1.45064F, 1.45064F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade", "armatureRoot", new Vector3(2.21722F, 2.21872F, -1.72181F), new Vector3(350.3033F, 0F, 0F), new Vector3(2.53434F, 2.53434F, 2.53434F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework", "armatureRoot", new Vector3(0F, 3.03576F, -2.01965F), new Vector3(273.6752F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger", "armatureRoot", new Vector3(2.38429F, 2.12887F, 3.84103F), new Vector3(0F, 217.489F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown", "armatureRoot", new Vector3(1.66912F, 3.83517F, 0F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron", "armatureRoot", new Vector3(-1.19975F, 2.96774F, -1.19594F), new Vector3(287.9433F, 295.6711F, 168.4785F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ShieldOnly,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule()
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayShieldBug"),
                            childName = "armatureRoot",
localPos = new Vector3(-0.58992F, 5.33209F, 0.0375F),
localAngles = new Vector3(41.59296F, 121.3665F, 41.12953F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule()
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayShieldBug"),
                            childName = "armatureRoot",
localPos = new Vector3(-1.13292F, 5.33209F, 0.0375F),
localAngles = new Vector3(329.1536F, 48.05566F, 238.8605F),
localScale = new Vector3(-1F, -1F, 1F),
                            limbMask = LimbFlags.None
                        },
                    }
                }
            });
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead", "armatureRoot", new Vector3(0.40818F, 2.93064F, 4.04669F), new Vector3(284.0064F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl", "armatureRoot", new Vector3(1.10839F, 3.40163F, -1.21686F), new Vector3(0F, 0F, 0F), new Vector3(0.22854F, 0.22854F, 0.22854F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland", "armatureRoot", new Vector3(1.80417F, 2.32681F, 2.7606F), new Vector3(0F, 0F, 0F), new Vector3(0.1F, 0.1F, 0.1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda", "armatureRoot", new Vector3(0.5316F, 3.97623F, 0F), new Vector3(359.8804F, 209.0348F, 180F), new Vector3(0.61564F, 0.61564F, 0.61564F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag", "armatureRoot", new Vector3(1.93028F, 3.37167F, 0F), new Vector3(0F, 0F, 0F), new Vector3(0.12523F, 0.12523F, 0.12523F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb", "armatureRoot", new Vector3(-1.30187F, 3.97785F, 1.20178F), new Vector3(0F, 0F, 85.41123F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey", "armatureRoot", new Vector3(-0.61325F, 3.92297F, 1.36738F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound", "armatureRoot", new Vector3(2.23999F, 2.10363F, -0.53053F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler", "armatureRoot", new Vector3(0.76824F, 3.6539F, 2.6082F), new Vector3(282.5705F, 0F, 0F), new Vector3(0.62301F, 0.62301F, 0.31531F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing", "armatureRoot", new Vector3(0F, 2.96442F, 9.35341F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing", "armatureRoot", new Vector3(0F, 2.96442F, 9.09206F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble", "armatureRoot", new Vector3(0.94052F, 3.46692F, 0.34107F), new Vector3(301.1974F, 0F, 17.21301F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo", "armatureRoot", new Vector3(-1.1337F, 4.37909F, 0.5397F), new Vector3(0F, 0F, 0F), new Vector3(0.47821F, 0.47821F, 0.47821F)));

            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.UtilitySkillMagazine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayAfterburner"),
                            childName = "armatureRoot",
localPos = new Vector3(-2.05444F, 1.47766F, -3.79548F),
localAngles = new Vector3(0F, 180F, 180F),
localScale = new Vector3(2.39677F, 2.39677F, 1.22822F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayAfterburner"),
                            childName = "armatureRoot",
localPos = new Vector3(2.24763F, 1.47766F, -3.79548F),
localAngles = new Vector3(0F, 180F, 180F),
localScale = new Vector3(2.39677F, 2.39677F, 1.22822F),
                            limbMask = LimbFlags.None
                        },
                    }
                }
            });

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullcrown", "armatureRoot", new Vector3(0F, 0.7482F, 5.61384F), new Vector3(16.45626F, 0F, 0F), new Vector3(0.74277F, 0.74277F, 0.74277F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk", "armatureRoot", new Vector3(-0.68428F, 5.36166F, -0.37259F), new Vector3(335.9721F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseflower", "armatureRoot", new Vector3(-0.66413F, 5.61551F, -0.65365F), new Vector3(319.4672F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil", "armatureRoot", new Vector3(2.74356F, -0.1287F, -1.04624F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateMirroredDisplayRule(RoR2Content.Items.IncreaseHealing, "DisplayAntler", "armatureRoot", new Vector3(-1.53365F, 3.52668F, 3.14941F), new Vector3(0F, 250.6605F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird", "armatureRoot", new Vector3(-0.83013F, 5.32248F, 0F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine", "armatureRoot", new Vector3(2.45227F, 0.53904F, -4.06367F), new Vector3(312.662F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn", "armatureRoot", new Vector3(1.60068F, 2.15069F, 3.92812F), new Vector3(275.3195F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis", "armatureRoot", new Vector3(0.03215F, 1.05428F, 6.3448F), new Vector3(272.158F, 0F, 0F), new Vector3(1F, 1F, 0.58173F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart", "armatureRoot", new Vector3(-2.96517F, 1.66023F, 0F), new Vector3(0F, 324.0605F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask", "armatureRoot", new Vector3(-1.31978F, 3.34535F, 3.82491F), new Vector3(337.1349F, 332.3446F, 11.50893F), new Vector3(0.5387F, 0.5387F, 0.5387F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch", "armatureRoot", new Vector3(0.88491F, 3.31972F, 3.7943F), new Vector3(88.74431F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ArmorReductionOnHit, "DisplayWarhammer", "armatureRoot", new Vector3(1.83621F, 2.23578F, -1.11474F), new Vector3(0F, 36.5967F, 0F), new Vector3(0.51641F, 0.51641F, 0.51641F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower", "armatureRoot", new Vector3(-1.20121F, 5.22401F, -0.01107F), new Vector3(0F, 307.8986F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond", "armatureRoot", new Vector3(0F, 1.38022F, 4.73904F), new Vector3(0F, 0F, 0F), new Vector3(0.34362F, 0.34362F, 0.34362F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot", "armatureRoot", new Vector3(1.29449F, 3.12036F, 3.89981F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.MonsoonPlayerHelper, 
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireCoiled", "armatureRoot", new Vector3(0F, 0.90531F, 6.2912F), new Vector3(0F, 0F, 0F), new Vector3(2.55624F, 0.39181F, 1F)));
            
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved", "armatureRoot", new Vector3(0F, 0.47956F, 6.1735F), new Vector3(7.26222F, 0F, 0F), new Vector3(0.41572F, 0.41572F, 0.41572F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl", "armatureRoot", new Vector3(-0.837F, 4.82825F, -0.53174F), new Vector3(90F, 0F, 0F), new Vector3(0.48782F, 0.48782F, 0.48782F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ShinyPearl, "DisplayShinyPearl", "armatureRoot", new Vector3(-0.837F, 4.28633F, -0.53174F), new Vector3(90F, 0F, 0F), new Vector3(0.48782F, 0.48782F, 0.48782F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome", "armatureRoot", new Vector3(0.34376F, 4.04736F, 0.457F), new Vector3(277.0279F, 113.4826F, 246.3591F), new Vector3(0.10749F, 0.10749F, 0.10749F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine", "armatureRoot", new Vector3(2.16837F, 2.2501F, -3.34405F), new Vector3(83.9069F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye", "armatureRoot", new Vector3(0F, 3.35398F, 4.12865F), new Vector3(46.08852F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts", "armatureRoot", new Vector3(2.87094F, 0.94264F, 6.1561F), new Vector3(351.1016F, 93.54856F, 77.39495F), new Vector3(0.22608F, 0.22608F, 0.22608F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads", "armatureRoot", new Vector3(-0.06685F, 2.97276F, 4.8492F), new Vector3(0F, 0F, 281.7356F), new Vector3(2.99909F, 2.99909F, 2.99909F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.InvadingDoppelganger, 
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate", "armatureRoot", new Vector3(-0.10757F, 2.83106F, 4.78941F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret", "armatureRoot", new Vector3(-0.74211F, 3.49961F, 0F), new Vector3(0F, 0F, 0F), new Vector3(0.43968F, 0.43968F, 0.43968F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark", "armatureRoot", new Vector3(0F, 3.59636F, 3.35827F), new Vector3(270.3257F, 180F, 180F), new Vector3(0.05172F, 0.05172F, 0.05172F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant", "armatureRoot", new Vector3(0F, 3.96961F, 1.33264F), new Vector3(270F, 0.00001F, 0F), new Vector3(0.25832F, 0.25832F, 0.25832F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit", "armatureRoot", new Vector3(0.89333F, 0.51014F, -4.12244F), new Vector3(80.6823F, 180F, 180F), new Vector3(0.38265F, 0.38265F, 0.38265F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator", "armatureRoot", new Vector3(-0.7816F, 0.31343F, -4.08811F), new Vector3(0F, 0F, 0F), new Vector3(5.05442F, 5.05442F, 5.05442F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode", "armatureRoot", new Vector3(1.68461F, 2.19502F, 2.47099F), new Vector3(0F, 0F, 0F), new Vector3(0.08181F, 0.08181F, 0.08181F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth", "armatureRoot", new Vector3(1.01832F, 2.08456F, -1.9652F), new Vector3(0F, 0F, 0F), new Vector3(1F, 0.17047F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse", "armatureRoot", new Vector3(1.77454F, 2.12393F, 4.19262F), new Vector3(0F, 0F, 91.70083F), new Vector3(0.15329F, 0.15329F, 0.15329F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone", "armatureRoot", new Vector3(-0.23345F, 3.83655F, -1.36943F), new Vector3(84.73903F, 0F, 0F), new Vector3(0.18747F, 0.18747F, 0.00779F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw", "armatureRoot", new Vector3(1.07537F, 3.2435F, 3.94F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart", "armatureRoot", new Vector3(-2.62871F, 5.04326F, -0.82376F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.RoboBallBuddy, "DisplayEmpathyChip", "armatureRoot", new Vector3(1.15873F, 1.62543F, 4.53445F), new Vector3(272.7796F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg", "armatureRoot", new Vector3(-0.86962F, 2.90273F, -4.30172F), new Vector3(0F, 0F, 0F), new Vector3(0.43426F, 0.43426F, 0.43426F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Items.SummonedEcho, 

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack", "armatureRoot", new Vector3(-1.50078F, 3.93895F, 2.10706F), new Vector3(0F, 195.9174F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit", "armatureRoot", new Vector3(1.04169F, 2.85519F, 0F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Equipment.Meteor, "DisplayMeteor", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateZMirroredDisplayRule(RoR2Content.Equipment.AffixRed, "DisplayEliteHorn", "armatureRoot", new Vector3(1.96258F, 0.86405F, 2.58423F), new Vector3(61.46677F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixBlue, "DisplayEliteRhinoHorn", "armatureRoot", new Vector3(-0.82756F, 5.13931F, -0.12774F), new Vector3(335.8539F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown", "armatureRoot", new Vector3(-0.80819F, 5.86428F, -0.34256F), new Vector3(273.8367F, 180F, 180F), new Vector3(0.10113F, 0.10113F, 0.10113F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown", "armatureRoot", new Vector3(0F, 0F, 0F), new Vector3(280.2108F, 180F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant", "armatureRoot", new Vector3(-0.81453F, 4.97361F, 0.53828F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio", "armatureRoot", new Vector3(0.25808F, 3.91408F, 0.82652F), new Vector3(274.6131F, 313.6385F, -0.00004F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG", "armatureRoot", new Vector3(2.01101F, 3.90343F, 0.7426F), new Vector3(0F, 0F, 315.1285F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings", "armatureRoot", new Vector3(-0.79441F, 4.59417F, 0F), new Vector3(0F, 0F, 0F), new Vector3(0.33498F, 0.33498F, 0.33498F)));

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Lightning, "DisplayLightningArmLeft", "armatureRoot", new Vector3(-0.45592F, 4.41659F, 0.19034F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat", "armatureRoot", new Vector3(1.96269F, 4.27839F, -0.21132F), new Vector3(1.97207F, 91.91721F, 314.2081F), new Vector3(0.22226F, 0.22226F, 0.22226F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.LunarPotion, 
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion", "armatureRoot", new Vector3(0.11538F, 4.04883F, 0.27192F), new Vector3(0F, 0F, 0F), new Vector3(0.07338F, 0.07338F, 0.07338F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner", "armatureRoot", new Vector3(1.02361F, 3.88184F, 0F), new Vector3(295.4924F, 163.6265F, 180F), new Vector3(0.54186F, 0.54186F, 0.54186F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy", "armatureRoot", new Vector3(0.66493F, 3.955F, -0.71763F), new Vector3(0F, 189.5291F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase", "armatureRoot", new Vector3(0F, 3.86971F, 0.25977F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic", "armatureRoot", new Vector3(0F, 4.08641F, 0.20092F), new Vector3(276.7589F, 0.00002F, 331.8358F), new Vector3(0.19407F, 0.19407F, 0.19407F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray", "armatureRoot", new Vector3(-0.73707F, 4.42612F, 0.3254F), new Vector3(325.1096F, 0F, 0F), new Vector3(0.63981F, 0.63981F, 0.63981F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack", "armatureRoot", new Vector3(-2.03316F, 2.5113F, 0F), new Vector3(0F, 76.65273F, 0F), new Vector3(0.42138F, 0.42138F, 0.42138F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg", "armatureRoot", new Vector3(0F, 3.8989F, 0.39462F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown", "armatureRoot", new Vector3(0F, 6.45994F, -0.45871F), new Vector3(273.9112F, 180F, 180F), new Vector3(0.16243F, 0.16243F, 0.16243F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure", "armatureRoot", new Vector3(0F, 3.21123F, 8.13328F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerang", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler", "armatureRoot", new Vector3(0F, 3.01732F, -0.93528F), new Vector3(0F, 0F, 0F), new Vector3(0.59497F, 0.59497F, 0.59497F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit", "armatureRoot", new Vector3(-1.5078F, 5.90203F, -0.19877F), new Vector3(26.18572F, 67.11036F, 349.4462F), new Vector3(0.37426F, 0.37426F, 0.37426F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry", "armatureRoot", new Vector3(0.55487F, 4.03929F, -0.72676F), new Vector3(0F, 0F, 0F), new Vector3(0.10794F, 0.10794F, 0.10794F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixEcho, 
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar, Fire", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye", "armatureRoot", new Vector3(-0.74216F, 5.12595F, 0.5512F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            //IDRS NOTE: [AFFIXLUNAR] = I don't think EliteLunar, Fire is used?

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook", "armatureRoot", new Vector3(3.18885F, 1.21582F, 0F), new Vector3(60.7141F, 88.39641F, 268.6013F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion", "armatureRoot", new Vector3(0.94337F, 2.34634F, 3.9903F), new Vector3(0F, 0F, 0F), new Vector3(0.14509F, 0.14509F, 0.14509F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.HealingPotionConsumed, 
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion", "armatureRoot", new Vector3(-0.64417F, 4.27441F, -0.96724F), new Vector3(10.65909F, 0F, 0F), new Vector3(3.31765F, 3.31765F, 3.31765F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee", "armatureRoot", new Vector3(0F, 4.03148F, 0F), new Vector3(0F, 154.6651F, 0F), new Vector3(0.31404F, 0.31404F, 0.31404F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight", "armatureRoot", new Vector3(0F, 3.07214F, 6.89328F), new Vector3(0F, 90F, 0F), new Vector3(0.29665F, 0.29665F, 0.29665F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid", "armatureRoot", new Vector3(-0.85473F, 4.30996F, 0.80288F), new Vector3(0F, 0F, 0F), new Vector3(0.50616F, 0.50616F, 0.50616F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid", "armatureRoot", new Vector3(0F, 2.08537F, -2.87827F), new Vector3(0F, 0F, 0F), new Vector3(0.20147F, 0.20147F, 0.20147F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid", "armatureRoot", new Vector3(-0.33753F, 5.14937F, -0.37195F), new Vector3(0F, 0F, 292.5165F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank", "armatureRoot", new Vector3(0F, 1.45871F, -4.39553F), new Vector3(353.6681F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap", "armatureRoot", new Vector3(1.17284F, 4.11365F, 0.59215F), new Vector3(290.2629F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.BleedOnHitVoid, "DisplayTriTipVoid", "armatureRoot", new Vector3(2.5061F, 2.10152F, 4.28991F), new Vector3(308.9861F, 180F, 180F), new Vector3(0.49044F, 0.49044F, 0.49044F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid", "armatureRoot", new Vector3(-0.80768F, 4.98982F, 0.06856F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid", "armatureRoot", new Vector3(-0.61325F, 3.92297F, 1.36738F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid", "armatureRoot", new Vector3(0.94052F, 3.46692F, 0.34107F), new Vector3(301.1974F, 0F, 17.21301F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid", "armatureRoot", new Vector3(2.49932F, 3.2361F, 1.60916F), new Vector3(0F, 0F, 0F), new Vector3(0.3569F, 0.3569F, 0.3569F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid", "armatureRoot", new Vector3(1.97272F, 3.04944F, 0.12127F), new Vector3(356.5254F, 105.2454F, 359.0537F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.ExtraLifeVoid, "DisplayHippoVoid", "armatureRoot", new Vector3(-1.1337F, 4.37909F, 0.5397F), new Vector3(0F, 0F, 0F), new Vector3(0.47821F, 0.47821F, 0.47821F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid", "armatureRoot", new Vector3(2.77693F, 1.99599F, 0F), new Vector3(90F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid", "armatureRoot", new Vector3(0.89131F, 2.80105F, -4.19329F), new Vector3(354.3547F, 0F, 0F), new Vector3(0.34752F, 0.34752F, 0.34752F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch", "armatureRoot", new Vector3(-0.12286F, 4.27312F, 0.33574F), new Vector3(0F, 0F, 276.7717F), new Vector3(1F, 1.50269F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal", "armatureRoot", new Vector3(0F, 3.75167F, 2.92274F), new Vector3(304.7934F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM", "armatureRoot", new Vector3(0F, 2.9559F, 9.39397F), new Vector3(90F, 0F, 0F), new Vector3(0.3863F, 0.52956F, 0.3863F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt", "armatureRoot", new Vector3(0.21573F, 3.83383F, -1.86533F), new Vector3(0F, 342.4607F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos", "armatureRoot", new Vector3(0F, 3.95644F, -0.44552F), new Vector3(11.53869F, 0F, 0F), new Vector3(0.31455F, 0.31455F, 0.31455F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken", "armatureRoot", new Vector3(1.95832F, 3.51665F, 2.001F), new Vector3(0F, 78.86413F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies", "armatureRoot", new Vector3(1.77178F, 2.13629F, 1.73823F), new Vector3(84.48765F, 150.4903F, 180F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature", "armatureRoot", new Vector3(2.6728F, 1.96828F, 4.66338F), new Vector3(0.00001F, 132.1929F, 49.1611F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone", "armatureRoot", new Vector3(-2.66926F, 1.99715F, 4.64798F), new Vector3(0F, 43.83541F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm", "armatureRoot", new Vector3(1.71362F, 1.22978F, -3.67731F), new Vector3(90F, 179.2872F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing", "armatureRoot", new Vector3(0F, 2.95076F, 5.47821F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.LunarSun,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplaySunHead"),
                            childName = "armatureRoot",
localPos = new Vector3(-0.78921F, 6.23368F, -0.55621F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplaySunHeadNeck"),
                            childName = "armatureRoot",
localPos = new Vector3(-0.86407F, 4.55862F, -0.19925F),
localAngles = new Vector3(0F, 283.7607F, 12.2212F),
localScale = new Vector3(2.46972F, 2.46972F, 2.46972F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            //Not an item display
            ////itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.DroneWeapons, 
            // Unless you're a drone, you don't need these.
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.DroneWeaponsBoost, 
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.DroneWeaponsDisplay1, 
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.DroneWeaponsDisplay2, 
            itemRules.Add(ItemDisplayCore.CreateFollowerDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem", "armatureRoot", new Vector3(-0.6295F, 3.24497F, -1.96174F), new Vector3(2.64492F, 180F, 180F), new Vector3(0.603F, 0.603F, 0.603F)));

            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov", "armatureRoot", new Vector3(0.86314F, 3.95698F, 0F), new Vector3(272.6989F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine2", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            //IDRS NOTE: [VENDINGMACHINE] = Choose one
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.VendingMachine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayVendingMachine"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayVendingMachine2"),
                            childName = "armatureRoot",
                            localPos = Vector3.zero,
                            localAngles = Vector3.zero,
                            localScale = Vector3.one,
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            //IDRS NOTE: [BOSSHUNTER] = Keep both. DisplayBlunderbuss is the hat, and Dis 
            itemRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.BossHunter,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayBlunderbuss"),
                            childName = "armatureRoot",
localPos = new Vector3(0.52152F, 4.72188F, 0.92641F),
localAngles = new Vector3(84.8894F, 180F, 180F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplayCore.LoadDisplay("DisplayTricornGhost"),
                            childName = "armatureRoot",
localPos = new Vector3(-0.80317F, 5.80729F, -0.57558F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(1.85102F, 1.85102F, 1.85102F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed", "armatureRoot", new Vector3(0F, 0F, 0F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone", "armatureRoot", new Vector3(-2.58214F, 2.23801F, 1.81737F), new Vector3(16.68754F, 85.30946F, 358.6503F), new Vector3(1F, 1F, 1F)));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard", "armatureRoot", new Vector3(0.34996F, 3.91739F, 0.4456F), new Vector3(0F, 0F, 0F), new Vector3(1F, 1F, 1F)));
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid", "armatureRoot", new Vector3(-0.86422F, 4.98872F, -0.08396F), new Vector3(52.51224F, 0F, 0F), new Vector3(0.62824F, 0.62824F, 0.62824F)));
            //from claymen git
            //itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers", "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
            #endregion

            #region Modded
            if (PotmobilePlugin.scepterPluginLoaded)
            {
                AddScepterItemDisplay();
            }
            #endregion
            #endregion

            ItemDisplayRuleSet.KeyAssetRuleGroup[] item = itemRules.ToArray();
            itemDisplayRuleSet.keyAssetRuleGroups = item;
            //itemDisplayRuleSet.GenerateRuntimeValues();

            R2API.SkinIDRS.AddPair(HaulerIrohaPlugin.irohaSkinDef, itemDisplayRuleSet);
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void AddScepterItemDisplay()
        {
            var scepterDef = ItemDisplayCore.LoadScepterObject();
            itemRules.Add(ItemDisplayCore.CreateGenericDisplayRule(scepterDef, AncientScepter.ItemBase.displayPrefab,
                "armatureRoot", Vector3.zero, Vector3.zero, Vector3.one));
        }
    }
}
