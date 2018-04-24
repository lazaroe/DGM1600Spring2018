using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {
public int movespeed = 1;
public Vector3 userDirection = Vector3.right;

 public void Update()
 {
     transform.Translate(userDirection * movespeed * Time.deltaTime); 
 }
void OnTriggerEnter (Collider other) {

	if (other.CompareTag("Player"))
		{
            other.gameObject.SetActive(false);

			Destroy (gameObject);
        
		}
	if (other.CompareTag("Ground"))
		{
			Destroy (gameObject);
		}
	}
}

//ifstatement
//void