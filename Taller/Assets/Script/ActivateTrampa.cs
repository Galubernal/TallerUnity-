using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrampa : MonoBehaviour {
	public GameObject activarTrampa;
	public Rigidbody rock;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Personaje") {
			rock.GetComponent<Rigidbody> ().useGravity = true;

		}
	}
}
