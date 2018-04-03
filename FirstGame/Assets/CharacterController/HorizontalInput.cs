using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VerticalInput")]
public class HorizontalInput : InputBase {

	public string InputName = "Horizontal";
	public override float SetFloat()
	{
		return Input.GetAxis(InputName);
	}
}
