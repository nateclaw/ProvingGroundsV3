// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProvingGroundsV3 : ModuleRules
{
	public ProvingGroundsV3(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProvingGroundsV3",
			"ProvingGroundsV3/Variant_Platforming",
			"ProvingGroundsV3/Variant_Platforming/Animation",
			"ProvingGroundsV3/Variant_Combat",
			"ProvingGroundsV3/Variant_Combat/AI",
			"ProvingGroundsV3/Variant_Combat/Animation",
			"ProvingGroundsV3/Variant_Combat/Gameplay",
			"ProvingGroundsV3/Variant_Combat/Interfaces",
			"ProvingGroundsV3/Variant_Combat/UI",
			"ProvingGroundsV3/Variant_SideScrolling",
			"ProvingGroundsV3/Variant_SideScrolling/AI",
			"ProvingGroundsV3/Variant_SideScrolling/Gameplay",
			"ProvingGroundsV3/Variant_SideScrolling/Interfaces",
			"ProvingGroundsV3/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
