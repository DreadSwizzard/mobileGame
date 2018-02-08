using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRoll : MonoBehaviour {
	private float horizontal;
	// Use this for initialization
	void Start () {
		horizontal = Input.GetAxis ("Horizontal");
	}
	
	// Update is called once per frame
	void Update () {
		var foo = transform.rotation;
		foo.x = 0;
		foo.y = 0;
		transform.rotation = foo;
		//horizontal stoors the user input when they press a,d,left,right on a scale from -1 to 1
		//float horizontal = Input.GetAxis ("Horizontal");

		//create a push variable that combines the user imput
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
		if (Input.GetKey (KeyCode.A)) {
			backward ();
		}
		if (Input.GetKey (KeyCode.D)) {
			forward ();
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
}
