using DeployOnPrSample.Localization;
using Volo.Abp.Application.Services;

namespace DeployOnPrSample.Services;

/* Inherit your application services from this class. */
public abstract class DeployOnPrSampleAppService : ApplicationService
{
    protected DeployOnPrSampleAppService()
    {
        LocalizationResource = typeof(DeployOnPrSampleResource);
    }
}