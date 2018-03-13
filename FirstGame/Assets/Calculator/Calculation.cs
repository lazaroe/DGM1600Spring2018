using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject 
{
	public float aNum;
	public float bNum;
	public abstract float Calculate(string a, string b);
}

//abstract means that it is open for interpritation