using UnrealBuildTool;

public class TP_ChimpEditorTarget : TargetRules
{
    public TP_ChimpEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "TP_ChimpGame" });
    }
}
