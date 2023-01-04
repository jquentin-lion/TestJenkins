using System;

namespace LionStudios.Editor.AutomatedBuilding
{
    public class RealCMDArgsProvider : ICMDArgsProvider
    {
        public string[] Args => Environment.GetCommandLineArgs();
    }
}