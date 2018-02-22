using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
	int cupsInTheSink = 4;
    
     
    void Start () {
    {
        
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }
		bool shouldContinue = false;
          
        do
        {
            print ("Hello World");
            
        }while(shouldContinue == true);
		string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}
//loops are used to repeat certain types of codes. There are different types of loops
//While loops. It will repeat as long as the code is true
//Do While Loops. test the condition at the end of the body. The body is alwasy garantee to run once.
//for loops. it is made up of 3 sections. loops that involve counting if variables are known
//counting will beguin with zero
//foreach group. It is good for valuaring arrays. goes through a collection item by item until the end by which it stiops
//you cannot alter the behavior with a foreach loop.
//Loops are good for repeating