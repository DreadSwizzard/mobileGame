using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var foo = transform.rotation;
		foo.x = 0;
		foo.y = 0;
		transform.rotation = foo;
		//horizontal stoors the user input when they press a,d,left,right on a scale from -1 to 1
		float horizontal = Input.GetAxis ("Horizontal");

		//create a push variable that combines the user imput
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
	}
}
