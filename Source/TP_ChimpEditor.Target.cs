using UnrealBuildTool;

public class TP_ChimpEditorTarget : TargetRules
{
    public TP_ChimpEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V4;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
        ExtraModuleNames.AddRange( new string[] { "TP_ChimpGame" } );
    }
}
