using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

private bool _play = false;
private bool _info = false;
	public AudioClip click;


void OnGUI () 
	{
		GUI.Box (new Rect (Screen.width / 2 - 40,228,100,115), "Main Menu");


	
	// Toggle _play on Inventory button click.
		if (GUI.Button (new Rect (Screen.width / 2 - 30,255,75, 20), "Play")) 
	{
		_play = !_play;
			GetComponent<AudioSource>().PlayOneShot(click);

	}
	
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 285, 75, 20), "Info :"))
	{
			_info = !_info;
			GetComponent<AudioSource>().PlayOneShot(click);


	}
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 315, 75, 20), "Exit"))
		{
			Debug.Break();
			GetComponent<AudioSource>().PlayOneShot(click);


		}
	
	// If _isInventoryOpen is true, draw the invetory rectangle.
	if (_play) 
	{
			Debug.Log ("Lets Begin !");
			Application.LoadLevel(1);
	}
    if (_info)
	{
			Debug.Log ("you opened Info");
			Application.LoadLevel(3);
			  
	}
	
    }
}