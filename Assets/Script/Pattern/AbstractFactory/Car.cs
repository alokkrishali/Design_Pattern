using System.Collections;
using UnityEngine;

namespace Assets.Script.Pattern.AbstractFactory
{
    public class Car : MonoBehaviour
    {

        ICar car;

        string carName;
        // Start is called before the first frame update
        private void OnGUI()
        {
            if (GUI.Button(new Rect(100, 100, 100, 50), "Create Car"))
            {
                car = CarFactory.GetCar(new HondaAmazeCarFactory());

                carName = car.CarName();
                if (carName != null)
                    Debug.Log(carName);
            }
        }
    }
}