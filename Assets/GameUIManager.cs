using UnityEngine;
using System.Collections;

public class GameUIManager : MonoBehaviour {

	bool isPaused = false;

	public void Restart()
	{
		Application.LoadLevel("RocketMouse");
	}
	public void Quit() 
	{
		Application.LoadLevel("MenuScene");
	}
	public void pause()
	{
		isPaused = !isPaused;
		if (isPaused) Time.timeScale = 0;
		else Time.timeScale = 1;
	}
}
