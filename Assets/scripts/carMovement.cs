using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour {
	float horizontal;
	public float speed = 5.0f;
	bool grounded = false;
	public float rotationSpeed = 30;
	// Use this for initialization
	void Start () 
	{
		// call bools
		vehicleControll doThing = new vehicleControll ();
		bool forwardBool = doThing.ForwardTrue ();
		bool backwardBool = doThing.BackwardTrue ();

		horizontal = Input.GetAxis ("Horizontal");
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded == false) {
			var foo = transform.rotation;
			foo.x = 0;
			foo.y = 0;
			transform.rotation = foo;
			//horizontal stoors the user input when they press a,d,left,right on a scale from -1 to 1
			//float horizontal = Input.GetAxis ("Horizontal");

			//create a push variable that combines the user imput
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (-horizontal);
			if (Input.GetKey (KeyCode.A) ) {
				backward ();
			}
			if (Input.GetKey (KeyCode.D)) {
				forward ();
			}
		} 
	}
	public void backward()
	{
		horizontal = -1;
	}

	public void forward()
	{
		horizontal = +1;
	}

	public void Grounded(){
		grounded = true;
	}

	public void notGrounded(){
		grounded = false;
	}


}
