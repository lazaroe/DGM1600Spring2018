using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;

	private void OnTriggerEnter (Collider obj)
	{
		print(obj.name);
	}

}
