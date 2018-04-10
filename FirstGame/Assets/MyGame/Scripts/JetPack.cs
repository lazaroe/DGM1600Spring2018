using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour {
 public float fuel = 60.0f;
    public float fuelUsing = 4.0f;
    public float maxFuel = 300.0f;

    public float JetForce = 5.0f;
    public float FlyingTime = 10000f;

    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().useGravity = false;
    }

    void FixedUpdate()
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        if ((fuel >= 0) && (Input.GetKey(KeyCode.Space)) && (FlyingTime >= 0))
        {
            GetComponent<Rigidbody>().AddForce(
                    new Vector3(transform.forward.x,  /* what goes here? */ transform.forward.z), ForceMode.VelocityChange);

            FlyingTime -= Time.deltaTime;
        }

        GetComponent<Rigidbody>().AddForce(
                new Vector3(0 * GetComponent<Rigidbody>().mass, 0));
    }
}
