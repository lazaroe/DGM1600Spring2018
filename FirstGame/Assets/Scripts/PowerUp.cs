using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject {
	public int PowerLevel = 10;
	public Player CurrentPlayer; 
	public void RunPowerUp ()
	{
		//Adds Value
		CurrentPlayer.Score += PowerLevel;
	}
	public string Name = "Health";

}

//Scriptable objects downsize the mass of the file, Monobehaviour is a bigger box. Mono can be used as scriptable objects on unity.
// you place ; only if you are going to assign it to do something
//Debug means find and Log menas report
// CreateAssetMenu will enable you to make it an asset that you can utilize and maniupalte differently
//Monobehaviours can be applied to any object
//Scriptable objects are manipulated in game.