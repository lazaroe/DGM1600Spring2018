using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements1 : MonoBehaviour
{
    public int intelligence = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Why hello there good sir! Let me teach you about Trigonometry!");
            break;
        case 4:
            print ("Hello and good day!");
            break;
        case 3:
            print ("Whadya want?");
            break;
        case 2:
            print ("Grog SMASH!");
            break;
        case 1:
            print ("Ulg, glib, Pblblblblb");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }
}
//Allow you to branch and decide alternative outcomes.
//Switch statements are cleaner than if statements because they only require one expression to be valued once
//you can only restrict them to a string type, int. 
//if more than one model have subquently code you can put them right next to eachother
