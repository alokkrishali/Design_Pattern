

namespace Assets.Script.Pattern.AbstractFactory
{
    public class HondaAmazeCar : ICar
    {
        public void ApplyBreak()
        {
            throw new System.NotImplementedException();
        }

        public void CarColour()
        {
            throw new System.NotImplementedException();
        }

        public string CarName()
        {
            return "Honda Amaze Car";
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}