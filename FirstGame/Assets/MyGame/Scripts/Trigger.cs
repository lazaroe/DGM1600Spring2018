using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {
	public PowerUp PowerUp;
	public Movement PlayerMovement;

	private void OnTriggerEnter(Collider obj)
 	{

		obj.GetComponent<PlayerMovement>().Movement = PowerUp.MovePatternTransfer;
		Destroy(gameObject);
 	}

}

//class