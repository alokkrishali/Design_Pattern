

namespace Assets.Script.Pattern.AbstractFactory
{
    public class CarFactory
    {
        internal static ICar GetCar(ICarAbstractFactory carFactory)
        {
            return carFactory.CreateAbstractCar();
        }
    }

    public interface ICar
    {
        public void Move();
        public void ApplyBreak();
        public void CarColour();
        public string CarName();
    }
}
