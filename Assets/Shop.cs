using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CustomerProfile obj = new StationaryCustomer();
        CustomerProfile obj1 = new GroceryCustomer();
        Debug.LogError(" Stationary Customer called from start - " + obj.IsloyalCustomer());
        Debug.LogError(" Grocery Customer called from start - " + obj1.IsloyalCustomer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public interface CustomerProfile
{
    public bool IsloyalCustomer();
}

public class GroceryCustomer : CustomerProfile
{
    public bool IsloyalCustomer()
    {
        Debug.LogError(" Loyal GroceryCustomer");
        return true;
    }
}

public class StationaryCustomer : CustomerProfile
{
    public bool IsloyalCustomer()
    {
        Debug.LogError(" Loyal StationaryCustomer");
        return true;
    }
}