// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "MotionMatching_TestGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AMotionMatching_TestGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AMotionMatching_TestGameMode();
};



