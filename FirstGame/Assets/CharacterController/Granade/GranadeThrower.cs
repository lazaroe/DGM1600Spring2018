using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeThrower : MonoBehaviour {

 public float throwforce = 40f;
 public GameObject GrenadePrefab;
 
 // Update is called once per frame
 void Update () {
  if (Input.GetKey ("g")) 
  {
   ThrowGrenade();
  }
 }

 void ThrowGrenade()
 {
  GameObject grenade = Instantiate (GrenadePrefab, transform.position, transform.rotation);
  Rigidbody rb = grenade.GetComponent<Rigidbody> ();
  rb.AddForce (transform.forward * throwforce, ForceMode.VelocityChange);
 }
}