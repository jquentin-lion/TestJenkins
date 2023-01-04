using UnityEngine;

namespace LionStudios.Editor.AutomatedBuilding
{
    [CreateAssetMenu(fileName = "AndroidBuildSettings", menuName = "Build/CreateAndroidBuildSettings")]
    public class AndroidBuildSettings : ScriptableObject
    {
        public string KEY_STORE_PATH = "keystore/srg.keystore";
        public string KEY_STORE_PASS = "6oVj3R9Xp1MMgJ6zypqZJ9X54fwyLqlDf521R3zLguA=";
        public string KEY_STORE_ALIAS = "srg studios";
        public string KEY_STORE_ALIAS_PASS = "6oVj3R9Xp1MMgJ6zypqZJ9X54fwyLqlDf521R3zLguA";
        
        public string AdditionalDefineSymbols;
        public string DefaultBuildFolder = "builds/android";
    }
}