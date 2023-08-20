using System;
using BepInEx;
using Potmobile;
using Potmobile.Survivors.Hauler;
using R2API;
using RoR2;
using UnityEngine;

namespace RoR2HaulerIrohaSkin
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.Moffein.Potmobile")]
    [BepInPlugin("com.Schale.HaulerIrohaSkin", "Hauler Iroha Skin", "1.0")]
    public class HaulerIrohaPlugin : BaseUnityPlugin
    {
        public static SkinDef irohaSkinDef;

        public static PluginInfo PInfo { get; set; }

        public void Awake()
        {
            PInfo = Info;

            Assets.Init();
            AddSkins();
            LanguageAPI.Add("MOFFEINHAULERBODY_SKIN_IROHA_NAME", "Iroha");
            RoR2.ContentManagement.ContentManager.onContentPacksAssigned += ContentManager_onContentPacksAssigned;
        }

        private void ContentManager_onContentPacksAssigned(HG.ReadOnlyArray<RoR2.ContentManagement.ReadOnlyContentPack> obj)
        {
            HaulerIrohaItemDisplays.RegisterDisplays();
        }

        private void AddSkins()
        {
            if (irohaSkinDef != null) return;
            var model = PotmobileContent.HaulerBodyObject.GetComponentInChildren<ModelLocator>().modelTransform.gameObject;
            CharacterModel characterModel = model.GetComponent<CharacterModel>();

            irohaSkinDef = Potmobile.Skins.CreateSkinDef("MOFFEINHAULERBODY_SKIN_IROHA_NAME",
                Assets.mainAssetBundle.LoadAsset<Sprite>("Assets/Resources/texIconIroha.png"),
                characterModel.baseRendererInfos,
                null,
                model);
            irohaSkinDef.name = "HaulerIrohaSkinDef";

            var asset = Assets.mainAssetBundle.LoadAsset<GameObject>("Assets/Resources/TankGirlPrefab.prefab");
            asset.transform.localScale = new Vector3(0.85f, 0.8f, 0.9f);

            var skinGo = HaulerSkins.ParentToHauler(asset.gameObject, true, new Vector3(0.85f, 0.8f, 0.9f), new Vector3(0, -1, 0));
            HaulerSkins.AutoAddGameObjectActivations(irohaSkinDef, "Iroha", skinGo);
            var irohaMRArray = skinGo.GetComponentsInChildren<MeshRenderer>();
            foreach (var meshRenderer in irohaMRArray)
            {
                var rendererInfo = new CharacterModel.RendererInfo()
                {
                    defaultMaterial = meshRenderer.sharedMaterial,
                    defaultShadowCastingMode = meshRenderer.shadowCastingMode,
                    hideOnDeath = false,
                    ignoreOverlays = false,
                    renderer = meshRenderer
                };
                HG.ArrayUtils.ArrayInsert(ref irohaSkinDef.rendererInfos, 0, in rendererInfo);
            }
        }
    }
}
