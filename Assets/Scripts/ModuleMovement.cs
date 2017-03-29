using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleMovement : MonoBehaviour {
	public float thrusterPower;
	private float getLocation;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
		Propulsion();
	}

	void Movement() {
		if (Input.GetKeyDown(KeyCode.A))
		{
			transform.Rotate(Vector3.forward * -5);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			transform.Rotate(Vector3.forward * 5);
		}
	}

	void Propulsion() {

		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		getLocation = transform.rotation.eulerAngles.z;
		if (Input.GetKeyDown(KeyCode.Space))
		{
			

			if ( getLocation == 0f){
				rb.velocity = Vector3.zero;
				rb.Sleep();
				rb.AddForce(Vector2.up * thrusterPower);
			}

			else if (getLocation >= 5f & getLocation <= 50f)
			{
				rb.velocity = Vector3.zero;
				rb.Sleep();
				rb.AddForce(Vector2.left * thrusterPower);
			}

			else if (getLocation > 50f)
			{
				rb.velocity = Vector3.zero;
				rb.Sleep();
				rb.AddForce(Vector2.right * thrusterPower);
			}
		}
	}
}
