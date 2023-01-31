namespace BicycleBuilderExample;

internal class Director
{
    private IBicycleBuilder builder;
    public Director(IBicycleBuilder builder)
    {
        this.builder = builder;
    }

    public void ChangeBuilder(IBicycleBuilder builder)
    {
        this.builder = builder;
    }

    public IBicycleProduct Make()
    {
        return builder.GetProduct();
    }
}
