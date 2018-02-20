using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour
 {

	public PowerUpBase MyPowerUp;

	void Start () 
	{
		
		switch (MyPowerUp.name)
		{
			case 100:
			print ("you have some amo");
			break;
			case 1000;
			print ("you hit a special, and you get 1000ammo");
			break;
		}
	}
}
