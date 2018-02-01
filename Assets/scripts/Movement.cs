using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//horizontal stoors the user input when they press a,d,left,right on a scale from -1 to 1
		float horizontal = Input.GetAxis ("Horizontal");

		//vertical stores user imput when they press w,s,up,down on a scale from -1 to 1
		float vertical = Input.GetAxis ("Vertical");

		//create a push variable that combines the user imput
		Vector2 push = new Vector2(horizontal, vertical);
		gameObject.GetComponent<Rigidbody2D> ().velocity = push * speed;
	}
}
