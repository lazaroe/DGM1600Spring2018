using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public bool key = false;
    public bool amo = false;

    void OnMouseDown()
        {
            if(key == true){
                print("Open Door");
            }
            if(amo == true){
                print("Shoot");
            }
        }
	}



//If statements just signify that if the content inside it is true then it is qualified to give a certain fuction or reaction
//You showed us what it means to have a double == which is really to compare
//you can check if something is false,  simply by putting a != meaning that anythign you select that is not a cat will meow
//We made 3 if statements in class, we discussed how we can make it so that we can interact with objects with if statements
//Bool is a swtich statement, its on or off.