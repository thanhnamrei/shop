using ObjectPoolExample;

Console.WriteLine("Here's a program that controls some welding robots from a pool of 10.");

var armPool = new WeldingArmPool
{
    MaxSize = 10,
};

var arm01 = armPool.GetArmFromPool();

arm01.MoveToStation(1);

if (arm01.DoWeld()) armPool.ReturnArmToPool(arm01);