using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class WheelRoll : MonoBehaviour {
	private float horizontal;
	public float speed = 1;
	public float maxSpeed = 10;
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
			if (GetComponent<Rigidbody2D> ().velocity.magnitude < maxSpeed) {
			backward ();
			//gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
			}
		}
		if (Input.GetKey (KeyCode.D)) {
			if (GetComponent<Rigidbody2D> ().velocity.magnitude < maxSpeed) {
				forward ();
				//gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal);
			}
		}
		//Debug.Log(CrossPlatformInputManager.GetAxis("Horizontal"));

		if (GetComponent<Rigidbody2D> ().velocity.magnitude < maxSpeed) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (-CrossPlatformInputManager.GetAxis ("Horizontal") * speed);
		}
	}
	public void backward()
	{
		horizontal = -1;
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal*speed);
	}

	public void forward()
	{
		horizontal = +1;
		gameObject.GetComponent<Rigidbody2D>().AddTorque(-horizontal*speed);
	}


}
