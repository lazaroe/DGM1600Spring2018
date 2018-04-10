using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUp;
	public PlayerMovement PlayerMovement;

	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<PlayerMovement>().Movement = PowerUp.MovePattern;
		Destroy(gameObject);
	}
}
