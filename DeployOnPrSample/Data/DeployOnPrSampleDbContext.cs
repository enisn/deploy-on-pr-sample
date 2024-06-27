using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DeployOnPrSample.Data;

[ConnectionStringName("Default")]
public class DeployOnPrSampleDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
