using UnrealBuildTool;

public class TP_ChimpGameTarget : TargetRules
{
    public TP_ChimpGameTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V4;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "TP_ChimpGame" });
    }
}
