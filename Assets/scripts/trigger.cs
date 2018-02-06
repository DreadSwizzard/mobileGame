using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collision)
{//if feet run into an object on layer 8
	if (collision.gameObject.layer == 8) {
		//tell the player they can jump
			transform.parent.GetComponent<carMovement>().Grounded();
		}
	}
	void OnTriggerExit2D(Collider2D collision)
	{//if feet run into an object on layer 8
		if (collision.gameObject.layer == 8) {
			//tell the player they can jump
			transform.parent.GetComponent<carMovement>().notGrounded();
		}
	}

}