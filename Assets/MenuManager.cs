using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    	public void PlayButtonPressed()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ExitButtonPressed()
	{
		Application.Quit();
		// Debug.Log("Exit pressed");		
	}
}
