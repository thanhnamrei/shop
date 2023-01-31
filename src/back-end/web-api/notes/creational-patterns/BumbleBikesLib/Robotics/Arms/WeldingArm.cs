namespace BumbleBikesLib.Robotics.Arms;


public enum WelderTypes
{
    MIIG,
    TIG,
    Stick
}


public class WeldingArm
{
    public float DutyHours { get; set; }
    public float InputVoltage { get; set; }
    public float OutputRangeMin { get; set; }
    public float OutputRangeMax { get; set; }
    public WelderTypes Type { get; set; }

    public int CurrentPosition { get; set; }

    public bool DoWeld()
    {
        const int timeToWeld = 5000; // it takes 5 seconds to do a weld
        Thread.Sleep(timeToWeld);
        IncrementDutyHours(timeToWeld);
        return true;
    }

    public void MoveToStation(int stationId)
    {
        CurrentPosition = stationId;
    }

    private void IncrementDutyHours(float milliseconds)
    {
        DutyHours += milliseconds;
    }
}
