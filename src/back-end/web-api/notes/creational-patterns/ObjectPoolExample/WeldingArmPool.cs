using BumbleBikesLib.Robotics.Arms;

namespace ObjectPoolExample;

public class WeldingArmPool
{
    private int _maxSize = 10;
    public int MaxSize
    {
        get { return _maxSize; }
        set
        {
            _maxSize = value;
        }
    }

    private List<WeldingArm> Pool { get; set; }
    public int ArmsAvailable => Pool.Count;

    public void Reset()
    {
        Pool = new List<WeldingArm>();

        for (int i = 0; i < _maxSize; i++)
        {
            Pool.Add(new WeldingArm());
        }
    }

    public WeldingArmPool()
    {
        Reset();
    }

    public WeldingArm GetArmFromPool()
    {
        if (ArmsAvailable > 0)
        {
            var returnArm = Pool[0];
            Pool.RemoveAt(0);

            return returnArm;
        }

        throw new Exception("You are out of arms. Return some to the pool and try again.");
    }

    public void ReturnArmToPool(WeldingArm arm)
    {
        arm.CurrentPosition = 0;
        Pool.Add(arm);
    }
}
