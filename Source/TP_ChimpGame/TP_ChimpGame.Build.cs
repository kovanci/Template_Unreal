using UnrealBuildTool;

public class TP_ChimpGame : ModuleRules
{
    public TP_ChimpGame(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[] {
            "TP_ChimpGame"
        });

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "EnhancedInput",
            "NavigationSystem",
            "AIModule",
            "Niagara",
            "UMG",
            "GameplayTags",
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "SlateCore",
            "CommonUI"
        });
    }
}
