using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Calculation : ScriptableObject {
	public int Calculate(string a, string b)
	{
		int aNum = int.Parse(a);
		int bNum = int.Parse(b);
		return aNum + bNum;
	}

}
//scriptable objects don't use start or updates only monobehaviours
//parse means to convert