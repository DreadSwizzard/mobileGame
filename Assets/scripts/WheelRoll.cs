using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class WheelRoll : MonoBehaviour {
	private float horizontal;
	//private float vertical;
	// Use this for initialization
	void Start () {
		horizontal = Input.GetAxis ("Horizontal");
		//vertical = Input.GetAxis ("Vertical");
	
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
		//gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
		if (Input.GetKey (KeyCode.A)) {
			backward ();
			//gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
		}
		if (Input.GetKey (KeyCode.D)) {
			forward ();
			//gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
		}

		gameObject.GetComponent<Rigidbody2D>().AddTorque(CrossPlatformInputManager.GetAxis("Horizontal"));
	
	}
	public void backward()
	{
		horizontal = -1;
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
	}

	public void forward()
	{
		horizontal = +1;
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
	}


}
