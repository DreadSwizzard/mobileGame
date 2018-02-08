using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startmenue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void easy()
	{
		SceneManager.LoadScene("easy");
	}
	public void medium()
	{
		SceneManager.LoadScene("medium");
	}
	public void hard()
	{
		SceneManager.LoadScene("hard");
	}
}
