using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{   
    int myInt = 5;
    
    
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
    
    int MultiplyByTwo (int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}

//Void specefies functions that return no value.
//Void take no parameters
//ret stands for return. 
//
