

namespace Assets.Script.Pattern.AbstractFactory
{
    public class SwiftCarFactory : ICarAbstractFactory
    {
        public ICar CreateAbstractCar()
        {
            return new SwiftCar();
        }
    }
}