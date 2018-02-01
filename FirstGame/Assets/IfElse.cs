using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

	public bool Key;
	public int Health = 100;
	public string Password = "Swag";
	void Start () {
		
		if (Key)
		{
			print("I have the key.");
		}
		else
		{
			print("You shall not pass!");
		}
		
		if (Health > 0)
		{
			print("you can play.");
		}
		else
		{
			print("You're dead!");
		}

		if (Password == "Swag")
		{
			print("That's correct.");
		}
		else
		{
			print("Try again.");
		}
	}
}

//If statements contain truth, they are the determening factor to the outcome, the clause statement gives you an alternative outcome. 
//bool will give you a "yes or no" box
//int will give me the ability to type in a number
//string will give me the ablity to type in a word.
//The else clause will give you the oposite of what is true.. for example, truth is open. and the opposite of open is close. so close will become false. meaning that if you don't qualify to activate truth, then you will activate false.
//definitions =
//==
//!=
//>= greater than
//<=less than
//Switches are for more than two choices. If statements are for only 2 choices.
//