using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	GameObject[] pauseObjects;

	// Use this for initialization
	public void Start()
	{
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Update is called once per frame
	public void Update()
	{
		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		}
	}


	//Reloads the Level
	public void Reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	//controls the pausing of the scene
	public void pauseControl()
	{
		Time.timeScale = 1;
		hidePaused();
	}

	//shows objects with ShowOnPause tag
	public void showPaused()
	{
		foreach (GameObject g in pauseObjects)
		{
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused()
	{
		foreach (GameObject g in pauseObjects)
		{
			g.SetActive(false);
		}
	}

	//loads inputted level
	public void LoadLevel(string level)
	{
		SceneManager.LoadScene(level);
	}

	//exits the game
	public void quitGame()
    {
		Application.Quit();
    }
}

