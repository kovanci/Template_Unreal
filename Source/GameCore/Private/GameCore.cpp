#include "GameCore.h"
#include "Modules/ModuleManager.h"

#include "Log.h"

void FGameCore::StartupModule()
{
    UE_LOG(LogGameCore, Log, TEXT("GameCore module starting up"));
}

void FGameCore::ShutdownModule()
{
    UE_LOG(LogGameCore, Log, TEXT("GameCore module shutting down"));
}

IMPLEMENT_PRIMARY_GAME_MODULE(FGameCore, GameCore, "GameCore");
