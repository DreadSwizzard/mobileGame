using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour {
	public float speed = 5.0f;
	bool grounded = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded == false)
		{
			var rot = transform.rotation;
			rot.x =0;
			rot.y = 0;
			rot.z = Input.GetAxis ("Horizontal");
		}
		//horizontal stoors the user input when they press a,d,left,right on a scale from -1 to 1
		float horizontal = Input.GetAxis ("Horizontal");

		//vertical stores user imput when they press w,s,up,down on a scale from -1 to 1
		float vertical = Input.GetAxis ("Vertical");

		//create a push variable that combines the user imput
		Vector2 push = new Vector2(horizontal, vertical);
		//gameObject.GetComponent<Rigidbody2D> ().velocity = push * speed;
		var w1 = GameObject.Find("Wheel1").transform.position;
		var w2 = GameObject.Find ("Wheel2").transform.position;
		Vector3 pos = w2 - w1;
		transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D Collision)
	{
		if (Collision.gameObject.layer == 8)
		{
			grounded = true;
		}
		else 
		{
			grounded= false;
		}
	}



}
