using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotate : MonoBehaviour {

   public GameObject[] players;
    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
     string[] strings = new string[3];
        
        strings[0] = "Dont get hit by the fireballs!";
        strings[1] = "Secret passage through the troches!";
        strings[2] = "Speed boost is found at the bottom of the map";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
    public enum Direction {A, D};
     Direction ReverseDirection (Direction dir)
    {
        if(dir == Direction.A)
            dir = Direction.D;
        else if(dir == Direction.D)
            dir = Direction.A;
        
        return dir;     
    }
}

//Arrays
//Enumerators
//foreach