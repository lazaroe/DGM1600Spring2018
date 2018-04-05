using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VerticalInput")]
public class HorizontalInput : InputBase {

	public string InputName = "Jump";
	public float FloatValue = 1;
	public override float SetFloat()
	{
		if (Input.GetButton(InputName))
		{
			return FloatValue;
		}
		else
		{
			return 0;
		}
	}
}
//it is the same as saying return Input.GetButton(InputName) ? FloatValue : 0;