using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {
	public GameObject car;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position; 
		position.x = car.transform.position.x;
		position.y = car.transform.position.y;
		transform.position = position;
	}
}
