using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public Rigidbody rb;

	public float sidewaysForce = 30f;


	void FixedUpdate () {


		if (Input.GetKey("d"))
		{

			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if (Input.GetKey("w"))
		{

			rb.AddForce (0, 0, sidewaysForce * Time.deltaTime ,ForceMode.VelocityChange);	
		}if (Input.GetKey("s"))
		{
			rb.AddForce (0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);	
		}

	} 
}
