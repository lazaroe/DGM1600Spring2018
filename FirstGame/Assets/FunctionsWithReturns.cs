using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {

	public int Health;
	public int AddHealth(int value)
	{
		print("Hello there");
		return Health += value;
	}
	private void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("Bob"));
	}
	//example1

	public List<string> Players;

	public List<string> NewPlayers ()
	{
		return new List<string>();
	}

	public string NewPlayer (string name)
	{
		return name; 
	}
	//example 2
}
//The first in Start does work, then the rest does work.
//it needs to be called an int in order to return an int.
//done with an array
//