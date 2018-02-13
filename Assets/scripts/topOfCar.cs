using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class topOfCar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D collision)
	{if (collision.gameObject.layer == 8)
	{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}


}
