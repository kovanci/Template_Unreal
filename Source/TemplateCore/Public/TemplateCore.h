#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FTemplateCore : public IModuleInterface
{
public:
	static inline FTemplateCore& Get()
	{
		return FModuleManager::LoadModuleChecked<FTemplateCore>("TemplateCore");
	}

	static inline bool IsAvailable()
	{
		return FModuleManager::Get().IsModuleLoaded("TemplateCore");
	}

	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
