using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

	public string UserName;

	void Start (){
		switch (UserName)
		{
			case "Password":
			print("open door");
			break;
			case "LevelUp":
			print("You are stronger");
			break;
			case "Weapon":
			print("good times");
			break;

			default:
			print ("swag");
			break;
		}
	}
}

//Switch statments always beguin with Switch ();
//Example would be sometihng like this.... Switch (string); {Case "Password":}//do work
//Switch statements have to go inside of a function
//in Switch statements you can case more than one things
//default means that if it doesn't dow whats in case, it will do whats in default. so example. if else is not present, default will kick in.
//switches can replace if statments, they are more condiced and make it look nicer
//