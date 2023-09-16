using UnrealBuildTool;

public class TP_ChimpTarget : TargetRules
{
    public TP_ChimpTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V4;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
        ExtraModuleNames.AddRange( new string[] { "TP_Chimp" } );
    }
}
