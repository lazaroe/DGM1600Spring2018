using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
    //this declares what start will do
        public string Name;
        public int foodCount;

        void OnMouseDown()
        {
            print("The" + Name + "ate my homework");
            print("The" + Name + " only has" + foodCount + "amount of food");
        }
	}



//Today in class we talked about Variables which are in essence boxes that contain information.
//We see that the format to this equation is much like this, you insert TYPE NAMEOFVARIABLE = Value; this give sour variables value in the game
//you can also create temporary variables that can add on to the original variable to complete a task..
//We talked about the meaing of integers or Int. we talked about how they are whole numbers.
//We talked about Floats and how they aren't whole numbers, an example would be like 1.1
//We learned how scripts and variables can be used for any object, you can reuse any script while yet having each object have thier own unique characteristics