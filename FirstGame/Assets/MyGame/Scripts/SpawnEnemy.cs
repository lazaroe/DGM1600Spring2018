using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

     public int ufoSpeed;
     public float Timer = 2;
     public GameObject clone;
     GameObject Clone;

     private Transform ObjectLocation;
     void Update()
 	{
     Timer -= Time.deltaTime;
     if (Timer <= 0f)
     {
         Clone = Instantiate(clone, ObjectLocation) as GameObject;
         Timer = 2f;
     }
 	}
}
//Clone = Instantiate(clone, new Vector3(Random.Range(-9, 9), 5f, 0f), transform.rotation) as GameObject;