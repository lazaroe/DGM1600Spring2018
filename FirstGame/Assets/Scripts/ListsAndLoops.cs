using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour {

	public TheIncredibles TheIncredibles;
	public Text AddMember;
	void OnmouseDown () 
	{

		TheIncredibles.FamilyList.Add(AddMember.text);
		
	}
}
//list NEED to have System.Collection.Generic
//Why would we use a list over an array? they both look the same in editor. but it is different in gameplay. arrays are good for things that you already have, but lists are really good for when you are collecting things.
//Arrays are not changeable in game. But List can be changed in game. 
//List can store.
