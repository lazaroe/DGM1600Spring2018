using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {

	public ParticleSystem ParticleSystem;

	private void OnTriggerEnter(Collider other)
	
	{
		 if (other.gameObject.CompareTag ( "Death"))
        {
		ParticleSystem.Emit(100);
		}
	}


}
