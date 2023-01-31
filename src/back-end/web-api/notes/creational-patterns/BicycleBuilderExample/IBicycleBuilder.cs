namespace BicycleBuilderExample;

public interface IBicycleBuilder
{
    public void Reset();
    public void BuildFrame();
    public void BuildSeat();
    public void BuildDriveTrain();
    public IBicycleProduct GetProduct();
}
