using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCharacter : MonoBehaviour {

    public Movement Movement;
	private CharacterController controller;
	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
    void Update() {
      //Movement.Move(controller, transform);
        
    }
}

//methods have paranthesis while methods do not
//time.deltatime means that it tries to run it on real time
//