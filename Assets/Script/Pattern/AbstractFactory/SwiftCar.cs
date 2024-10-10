

namespace Assets.Script.Pattern.AbstractFactory
{
    public class SwiftCar : ICar
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
            return "Swift Car";
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}