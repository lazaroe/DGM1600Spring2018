using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	 public static int movespeed = 1;
 public Vector3 userDirection = Vector3.right;
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
