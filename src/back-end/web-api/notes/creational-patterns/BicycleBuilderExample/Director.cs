namespace BicycleBuilderExample;

internal class Director
{
    private IBicycleBuilder _builder;
    public Director(IBicycleBuilder builder)
    {
        this._builder = builder;
    }

    public void ChangeBuilder(IBicycleBuilder builder)
    {
        this._builder = builder;
    }

    public IBicycleProduct Make()
    {
        return _builder.GetProduct();
    }
}
