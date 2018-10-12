using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
	public AudioClip click;

	public void MainMenuLoad () 
	{
		Application.LoadLevel (0);
	}

	public void InfoLoad () 
	{
		Application.LoadLevel (3);
	}

	public void PlayLoad () 
	{
		Application.LoadLevel (1);
	}

	public void ExitLoad () 
	{
		Application.Quit ();
	}
	
}