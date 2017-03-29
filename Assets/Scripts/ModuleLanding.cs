using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleLanding : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll) {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		if (coll.gameObject.tag == "Floor")
		{
            rb.velocity = Vector3.zero;
			rb.Sleep();
			Debug.Log("Failed");
		}

		if (coll.gameObject.tag == "Pad")
		{
			rb.velocity = Vector3.zero;
			rb.Sleep();
			Debug.Log("Success");
		}
	}
}
