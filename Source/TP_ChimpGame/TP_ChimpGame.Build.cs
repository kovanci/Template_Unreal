using UnrealBuildTool;

public class TP_ChimpGame : ModuleRules
{
    public TP_ChimpGame(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[] {
            "TP_ChimpGame"
        });

        PrivateIncludePaths.AddRange(new string[] {

        });

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "NavigationSystem",
            "AIModule",
            "Niagara",
            "GameplayTags"
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "InputCore",
            "Slate",
            "SlateCore",
            "DeveloperSettings",
            "EnhancedInput",
            "UMG",
            "CommonUI"
        });
    }
}
