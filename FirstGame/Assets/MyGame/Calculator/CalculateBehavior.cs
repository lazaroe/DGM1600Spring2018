using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalculateBehavior : MonoBehaviour 
{
	public InputField Input1;
	public InputField Input2;
	public Text SolutionText;
	public Calculation Calculation;
	public void RunCalculation()
	{
		SolutionText.text = Calculation.Calculate(Input1.text, Input2.text).ToString();
	}
}
//using unityengine.ui allows us to use ui for the scripts
//The only reason why we put ToString at en is because one is set to be an in and the other an string so it will give a solution as a string.
//