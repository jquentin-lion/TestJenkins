using UnityEngine;

namespace LionStudios.Editor.AutomatedBuilding
{
    [CreateAssetMenu(fileName = "CommonBuildSettings", menuName = "Build/CreateCommonBuildSettings")]
    public class CommonBuildSettings : ScriptableObject
    {
        public string ProjectName;
        public string DateFormat = "yy-MM-dd-HH-mm";
        public string DevAdditionalDefSymbols = "DEV";
        public string[] Scenes;
    }
}