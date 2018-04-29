using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public class enemy1{
        public float enemy = 1;
        public enemy1 (int enm)
        {
            enemy = enm;
        }
    }
     public float Timer = 2;
    private int enemy;
    public GameObject clone;
     float Enemies = 1;
     GameObject Clone;

     private Transform ObjectLocation;

     void Update()
 	{
     Timer -= Time.deltaTime;
     if (Timer <= 0f)
     {
          for(float l = 0; l < Enemies;l++)
        {
            Clone = Instantiate(clone, ObjectLocation) as GameObject;
            Timer = 2f;
        }  
     }
     }
}
//Clone = Instantiate(clone, new Vector3(Random.Range(-9, 9), 5f, 0f), transform.rotation) as GameObject;
//used a tutorial
//forloops
//float