using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QueryTest : MonoBehaviour
{
    // Start is called before the first frame update

    List<string> my_list = new List<string>(){
        "This is my Dog",
        "Name of my Dog is Robin",
        "This is my Cat",
        "Name of the cat is Mewmew"
    };
    void Start()
    {
        //var value = from item in my_list where item.Contains("Dog") select item;
        //var value = my_list.Where(a => a.Contains("Dog"));
        var value = my_list.FindAll(a=>a.Length>14);
        //var value = my_list.Any(a=>a.StartsWith("Name"));  // bool
        //var value = my_list.All(a=>a.EndsWith("Cat"));  // bool
        foreach (var a in value)
        {
        Debug.Log(a);
        }
        }

// Update is called once per frame
void Update()
{

}
}
