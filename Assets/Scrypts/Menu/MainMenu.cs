using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public void GameArena()
	{
		Application.LoadLevel (1);
	}

	public void GameExit()
	{
		Application.Quit ();
	}
}