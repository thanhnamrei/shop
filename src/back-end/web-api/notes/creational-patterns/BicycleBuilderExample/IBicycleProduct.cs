using BumbleBikesLib.BicycleComponents.BicycleFrame;
using BumbleBikesLib.BicycleComponents.Brakes;
using BumbleBikesLib.BicycleComponents.Drivetrain;
using BumbleBikesLib.BicycleComponents.Handlebars;
using BumbleBikesLib.BicycleComponents.Seats;

namespace BicycleBuilderExample;
public interface IBicycleProduct
{
    public IFrame Frame { get; set; }
    public IHandlebars Handlebars { get; set; }
    public ISeat Seat { get; set; }
    public IBrakes Brakes { get; set; }
    public IDrivetrain Drivetrain { get; set; }
}
