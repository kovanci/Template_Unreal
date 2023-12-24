using UnrealBuildTool;

public class TP_Chimp : ModuleRules
{
    public TP_Chimp(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[] {
            "TP_Chimp"
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
