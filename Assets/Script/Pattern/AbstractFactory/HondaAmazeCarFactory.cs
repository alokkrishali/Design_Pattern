

namespace Assets.Script.Pattern.AbstractFactory
{
    public class HondaAmazeCarFactory : ICarAbstractFactory
    {
        public ICar CreateAbstractCar()
        {
            return new HondaAmazeCar();
        }
    }
}