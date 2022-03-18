using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrampa : MonoBehaviour {
	public GameObject activarTrampa;
	public Rigidbody rock;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Tortuga") {
			Debug.Log ("Colision pared");
			rock.GetComponent<Rigidbody> ().useGravity = true;

		}
	}
	// Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update() {

	}
}
