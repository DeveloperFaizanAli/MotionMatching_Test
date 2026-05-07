// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MotionMatching_Test : ModuleRules
{
	public MotionMatching_Test(ReadOnlyTargetRules Target) : base(Target)
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
			"MotionMatching_Test",
			"MotionMatching_Test/Variant_Platforming",
			"MotionMatching_Test/Variant_Platforming/Animation",
			"MotionMatching_Test/Variant_Combat",
			"MotionMatching_Test/Variant_Combat/AI",
			"MotionMatching_Test/Variant_Combat/Animation",
			"MotionMatching_Test/Variant_Combat/Gameplay",
			"MotionMatching_Test/Variant_Combat/Interfaces",
			"MotionMatching_Test/Variant_Combat/UI",
			"MotionMatching_Test/Variant_SideScrolling",
			"MotionMatching_Test/Variant_SideScrolling/AI",
			"MotionMatching_Test/Variant_SideScrolling/Gameplay",
			"MotionMatching_Test/Variant_SideScrolling/Interfaces",
			"MotionMatching_Test/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
