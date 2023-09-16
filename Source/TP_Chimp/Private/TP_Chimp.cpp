#include "GameCore.h"
#include "Modules/ModuleManager.h"

#include "Log.h"

void FTP_Chimp::StartupModule()
{
    UE_LOG(LogTP_Chimp, Log, TEXT("TP_Chimp module starting up"));
}

void FTP_Chimp::ShutdownModule()
{
    UE_LOG(LogTP_Chimp, Log, TEXT("TP_Chimp module shutting down"));
}

IMPLEMENT_PRIMARY_GAME_MODULE(FTP_Chimp, TP_Chimp, "TP_Chimp");
