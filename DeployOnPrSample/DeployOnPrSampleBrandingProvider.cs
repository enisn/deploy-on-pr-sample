using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DeployOnPrSample;

[Dependency(ReplaceServices = true)]
public class DeployOnPrSampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DeployOnPrSample";
}
