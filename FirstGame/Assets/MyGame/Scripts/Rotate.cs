using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

  void Update ()
    {
       if (Input.GetKeyDown(KeyCode.D))
     {
        transform.rotation = Quaternion.Euler(0,180,0);
     }
	    if (Input.GetKeyDown(KeyCode.A))
     {
        transform.rotation = Quaternion.Euler(0,0,0);
     }
    }
}
