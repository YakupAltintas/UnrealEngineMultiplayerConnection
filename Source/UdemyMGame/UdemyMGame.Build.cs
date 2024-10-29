// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UdemyMGame : ModuleRules
{
	public UdemyMGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput","OnlineSubsystemSteam","OnlineSubsystem" });
	}
}
