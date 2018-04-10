using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

 	private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    public Movement Movement;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
        
        //my pick up countdown
         rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
	}
    void Update() {
      
        if (controller.isGrounded) {
			moveDirection.x = Input.GetAxis("Horizontal");
			moveDirection.z = 0;
			moveDirection.y = 0;
			
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= Movement.speed;

            if (Input.GetKey(KeyCode.Space))
                moveDirection.y = Movement.jumpSpeed;
       
            
        }
            else
            {
            moveDirection.x = Input.GetAxis("Horizontal");
			moveDirection.z = 0;
			moveDirection.y = 0;
			
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= Movement.speed;

            if (Input.GetKey(KeyCode.Space))
            moveDirection.y = Movement.jumpSpeed; 
            }
        moveDirection.y -= Movement.gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }
//number needed to win
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 1)
        {
            winText.text = "You Win!";
        }
    }
    
}