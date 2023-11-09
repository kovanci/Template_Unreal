#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FTP_Chimp : public IModuleInterface
{
public:
    static inline FTP_Chimp& Get()
    {
        return FModuleManager::LoadModuleChecked<FTP_Chimp>("TP_Chimp");
    }

    static inline bool IsAvailable()
    {
        return FModuleManager::Get().IsModuleLoaded("TP_Chimp");
    }

    virtual bool IsGameModule() const override
    {
        return true;
    }

    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
