using BumbleBikesLib.BicycleComponents.BicycleFrame;
using BumbleBikesLib.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public interface IBicycleFactory
{
    public IFrame CreateBicycleFrame();
    public IHandlebars CreateBicycleHandleBars();
}
