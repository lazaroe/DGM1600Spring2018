using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCharacter : MonoBehaviour {

	private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    public Movement Movement;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
    void Update() {
      
        if (controller.isGrounded) {
			moveDirection.x = Input.GetAxis("Horizontal");
			moveDirection.z = 0;
			moveDirection.y = Input.GetAxis("Vertical");
			
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= Movement.speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = Movement.jumpSpeed;
            
        }
        moveDirection.y -= Movement.gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}

//methods have paranthesis while methods do not
//time.deltatime means that it tries to run it on real time
//