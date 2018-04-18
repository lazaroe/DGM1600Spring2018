using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	 public int movespeed = 1;
 public Vector3 userDirection = Vector3.right;

 public int Difficulty = 3;
    
    
    void Level()
    {
        switch (Difficulty)
        {
        case 3:
            print ("Very Hard");
            break;
        case 2:
            print ("Hard");
            break;
        case 1:
            print ("Normal");
            break;
        default:
            print (".Normal.");
            break;
        }
    }

 public void Update()
 {
     transform.Translate(userDirection * movespeed * Time.deltaTime); 
 }
void OnTriggerEnter (Collider other) {

	if (other.CompareTag("Player"))
		{
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	if (other.CompareTag("Ground"))
		{
			Destroy (gameObject);
		}
	}
}
