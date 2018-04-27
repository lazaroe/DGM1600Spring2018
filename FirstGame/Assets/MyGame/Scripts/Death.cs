using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {

public List<GameObject> Fireballs;
public AudioSource Fire;
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
	foreach (GameObject Fireballs in Fireballs)
	{
		Fire.Play();
		Fire.Stop();
	}
	
	if (other.CompareTag("Ground"))
		{
			Destroy (gameObject);
		}
	}
}

//ifstatement
//void
//foreach