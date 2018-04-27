using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Add : Calculation {
	public override string FinishCalculation()
	{
		return (aNum + bNum).ToString();
	}

}
//scriptable objects don't use start or updates only monobehaviours
//parse means to convert
//override means that we are going to replace whatever was there.
//public, private, protected. protected means 