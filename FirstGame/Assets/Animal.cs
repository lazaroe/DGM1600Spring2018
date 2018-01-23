using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
    //this declares what start will do
	void Start () {
        print("my animal is eating.");
        print("now my animal is sleeping.");
        print("I love my dog");
	}

    void OnMouseDown()
    {
        Start();
        print("Woof");
    }
	// Update is called once per frame
	void Update () {
		
	}
}


//Today in class we made a big emphasis on Class and on Voids
//Class is what we could call the big box or the object that we can store things in, class would be animal and the voids is what go inside that
//Void is the "little boxes" or the functions that can make a command, if you make a prescript before hand to signify the type of action you want the void will enable you after typing a follow up comman such as start to get you the wanted reaction
//; this is what comes at the end of any coding sentence, this finishes the command.
//we talked about how this is the set up of a function and that anything else beyond this point consists of this, the only big thing we need to remember aside from this is just other words.
// using these you create notes that won't show up.
//you can also code commands to make sure that a type of call can give a spicific reaction.