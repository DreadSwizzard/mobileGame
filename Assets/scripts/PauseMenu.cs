using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public int number;
    
    // Update is called once per frame
    void Update()
    {
        //if we press escape or p, we should pause
        if (Input.GetKeyDown(KeyCode.Escape) ||
            Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            //assume this script is attached to 
            //pause menu canvas
            gameObject.GetComponent<Canvas>().enabled = true;
        }
    }

    public void Resume()
    {
        //reset the timescale to 1, and hide the canvas
        Time.timeScale = 1;
        gameObject.GetComponent<Canvas>().enabled = false;
    }
	public void QuitGame()
	{
		//this will stop the .ExecuteInEditMode Application from running after the game has been built
		Application.Quit();
	}
	public void Restart()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void returnToStart()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("start");
	}
}
