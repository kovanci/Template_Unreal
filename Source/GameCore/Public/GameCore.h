#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FGameCore : public IModuleInterface
{
public:
    static inline FGameCore& Get()
    {
        return FModuleManager::LoadModuleChecked<FGameCore>("GameCore");
    }

    static inline bool IsAvailable()
    {
        return FModuleManager::Get().IsModuleLoaded("GameCore");
    }

    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
