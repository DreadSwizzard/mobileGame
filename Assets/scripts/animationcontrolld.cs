using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrolld : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		float input_X = Input.GetAxisRaw ("Horizontal");
		float input_Y = Input.GetAxisRaw ("Vertical");
		bool iswalking = (Mathf.Abs (input_X) + Mathf.Abs (input_Y) > 0);
		anim.SetBool("iswalking", iswalking);
		if (iswalking) {
			anim.SetFloat ("x", input_X);
			anim.SetFloat ("y", input_Y);

		}
	}
}
