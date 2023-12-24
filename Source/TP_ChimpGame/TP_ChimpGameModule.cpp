#include "Modules/ModuleManager.h"

#include "TP_ChimpLogChannels.h"

class FTP_ChimpGameModule : public FDefaultGameModuleImpl
{
    virtual void StartupModule() override
    {
        UE_LOG(LogTP_Chimp, Log, TEXT("TP_ChimpGameModule module starting up"));
    }

    virtual void ShutdownModule() override
    {
        UE_LOG(LogTP_Chimp, Log, TEXT("TP_ChimpGameModule module shutting down"));
    }
};

IMPLEMENT_PRIMARY_GAME_MODULE(FTP_ChimpGameModule, TP_ChimpGame, "TP_ChimpGame");
