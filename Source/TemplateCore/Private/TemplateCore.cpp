#include "TemplateCore.h"
#include "Modules/ModuleManager.h"

#include "Log.h"

void FTemplateCore::StartupModule()
{
	UE_LOG(LogTemplateCore, Log, TEXT("TemplateCore module starting up"));
}

void FTemplateCore::ShutdownModule()
{
	UE_LOG(LogTemplateCore, Log, TEXT("TemplateCore module shutting down"));
}

IMPLEMENT_PRIMARY_GAME_MODULE(FTemplateCore, TemplateCore, "TemplateCore");
