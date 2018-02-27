using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Loops : MonoBehaviour {
	public string[] Keys;

	// Use this for initialization
	void Start () 
	{
			Run();

			private void Update()
			{
				if (Input.GetKeyDown(KeyCode.Space))
				{
					Run();
				}
			}
	void Run()
		{
		for (int i = 0; i < Keys.Length; i++)
		{
			if (Keys[i] == "Add Ammo")
			{
				print (Keys[i]);
			}
		}
	}
}
}
//for (); loops are just a pattern. It means that the work will continue to loop
//for loops are loops that can be specified. You declare I=0 
//scriptable objects can be saved.
//has to be set to 0 because that is where is starts.
//sometimes you can't use foreach loop. You have to use a for loop instead.
//i < Keys.Length; is an If statement. just that it's programed. and the "then" is i++ which means add one to the list.
//Size is the same word in unity as length. Collection is name, which is Key. 
//you would loop if you want to look for data
//i is shortcut for index. 
//For Void statements the first is to call it. and the second is to make it work.