﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public class enemy1{
        public int enemy = 1;
        public enemy1 (int enm)
        {
            enemy = enm;
        }
    }
     public float Timer = 2;
     public GameObject clone;
     int Enemies = 1;
     GameObject Clone;

     private Transform ObjectLocation;

     void Start()
     {
         for(int l = 0; l < Enemies;l++)
        {
            print ("enm" + 1); 
        }
     }
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
//used a tutorial
//forloops