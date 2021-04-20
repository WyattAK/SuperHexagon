using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
	public void StartAbout()
	{
		SceneManager.LoadScene("AboutMenu");
	}

	public void StartGame()
	{
		SceneManager.LoadScene("SuperHexagon");
	}
		
}