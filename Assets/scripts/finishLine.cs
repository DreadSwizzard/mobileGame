using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishLine : MonoBehaviour {


	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "car")
		{
			SceneManager.LoadScene("start");
		}

	}

}
