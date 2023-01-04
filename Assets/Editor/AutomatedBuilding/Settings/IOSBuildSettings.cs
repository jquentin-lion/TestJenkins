using UnityEngine;

namespace LionStudios.Editor.AutomatedBuilding
{
    [CreateAssetMenu(fileName = "IOSBuildSettings", menuName = "Build/CreateIOSBuildSettings")]
    public class IOSBuildSettings : ScriptableObject
    {
        public string TargetName = "Unity-iPhone";
        public string OrgName = "Lion Studios LLC";
        public string OrgCode = "4GT5PAZNM9";
        public string PovisioningProfileName = "InkInc_Distribution";
        public string AdditionalDefineSymbols;
        public string DefaultBuildFolder = "builds/ios";
    }
}