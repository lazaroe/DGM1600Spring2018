using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject 
{
	protected float aNum;
	protected float bNum;
	public string Calculate(string a, string b)
	{
		aNum = float.Parse(a);
		return FinishCalculation();
	}

    public abstract string FinishCalculation();
}

//abstract means that it is open for interpritation
//Parse can convert strings to numbers
//