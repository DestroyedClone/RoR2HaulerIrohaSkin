using Potmobile;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace RoR2HaulerIrohaSkin
{
    internal class Assets
    {
        public static AssetBundle mainAssetBundle;
        public const string bundleName = "ror2haulerirohabundle";
        public static string AssetBundlePath
        {
            get
            {
                return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(HaulerIrohaPlugin.PInfo.Location), bundleName);
            }
        }


        public static T LoadAddressable<T>(string path)
        {
            return Addressables.LoadAssetAsync<T>(path).WaitForCompletion();
        }

        public static void Init()
        {
            PopulateAssets();
        }
        public static void PopulateAssets()
        {
            mainAssetBundle = AssetBundle.LoadFromFile(AssetBundlePath);
        }
    }
}
