using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject {
	public int PowerLevel = 100;
	public string Name = "Health";

}

//Scriptable objects downsize the mass of the file, Monobehaviour is a bigger box. Mono can be used as scriptable objects on unity.
// you place ; only if you are going to assign it to do something