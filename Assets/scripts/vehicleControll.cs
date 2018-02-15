using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleControll : MonoBehaviour {
	public bool 
		forwardBool = false,
		backwardBool = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// pointer down
	public bool ForwardTrue ()
	{
		forwardBool = true;
	}
	// pointer up
	public bool ForwardFalse ()
	{
		forwardBool = false;
	}
	// pointer down
	public bool BackwardTrue ()
	{
		backwardBool = true;
	}
	// pointer up
	public bool BackwardFalse ()
	{
		backwardBool = false;
	}
}
