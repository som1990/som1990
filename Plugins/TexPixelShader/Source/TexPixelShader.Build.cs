using System.IO;

namespace UnrealBuildTool.Rules
{
    public class TexPixelShader : ModuleRules
    {
        public TexPixelShader(ReadOnlyTargetRules Target): base(Target)
        {
            PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
            PrivatePCHHeaderFile = "TexPixelShader/Private/TexPixelShaderPrivatePCH.h";

            PublicIncludePaths.AddRange(
                new string[]
                {
                    Path.Combine(ModuleDirectory, "TexPixelShader/Public")
                }
                
            );
            PrivateIncludePaths.AddRange(
                new string[] {
                    Path.Combine(ModuleDirectory,"TexPixelShader/Private")
                }
                );

            PublicDependencyModuleNames.AddRange(
                new string[]
                {
                    "Core",
                    "CoreUObject",
                    "Engine",
                    "RenderCore",
                    "ShaderCore",
                    "RHI"
                }

                );

            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "CoreUObject",
                    "Engine",
                   
                }
                );
        }
    }
}