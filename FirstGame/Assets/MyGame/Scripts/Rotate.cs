using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotate : MonoBehaviour {

   public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < players.Length; i++)
        {
           print("Player Number "+i+" is named "+players[i].name);
        }
    }
  public class EnumScript : MonoBehaviour 
{
    enum TurnSpeed {A,D};
    void Update()
    {
        
    }

}
}
