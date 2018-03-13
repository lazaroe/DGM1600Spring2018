using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Add : Calculation {
	public override float Calculate(string a, string b)
	{
		aNum = float.Parse(a);
		bNum = float.Parse(b);
		return aNum + bNum;
	}

}
//scriptable objects don't use start or updates only monobehaviours
//parse means to convert