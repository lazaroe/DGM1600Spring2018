using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour {

	public int A;
	public int B;
	public string Password;

	void Start () {
	if (A == B){
		print("equal");
	}
	if (A > B && Password == "Swag"){
		print("greater than");
	}
	if (A < B){
		print("less than");
	}
	if (A != B){
		print("not equal to");
	}

}
}

//functions are boxes that have to be called. It can also be called a Design pattern.
//public functions are placed above the start. It is underneath the start that we can place the reactions because that way we signify that it can start right away after we have chnaged the variables
//|| means or
//&& means AND
//one = assigning but == is comparing
//+= means that it adds to the value 