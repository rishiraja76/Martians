using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
	public AudioClip click;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 135, 200, 1000, 1000), "1 Sprites* and Audio provided by this license:");
		GUI.Label (new Rect (Screen.width / 2 - 135, 225, 1000, 1000), "http://creativecommons.org/licenses/by/3.0/deed");
		GUI.Label (new Rect (Screen.width / 2 - 135, 240, 1000, 1000), "(licensed under the Attribution 3.0 Unported license) ");
		GUI.Label (new Rect (Screen.width / 2 - 135, 255, 1000, 1000), "*EnvironmentSpriteAtlas");
		GUI.Label (new Rect (Screen.width / 2 - 135, 305, 1000, 1000), "Fonts by:");
		GUI.Label (new Rect (Screen.width / 2 - 135, 330, 1000, 1000), "http://www.dafont.com/piximisa.font ");
		GUI.Label (new Rect (Screen.width / 2 - 135, 345, 1000, 1000), "http://fc01.deviantart.net");
		GUI.Label (new Rect (Screen.width / 2 - 135, 360, 1000, 1000), "/fs27/i/2008/104/b/2/Cosmos_by_Pantoja.jpg");
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 444, 60, 20), "Back")) {
			GetComponent<AudioSource>().PlayOneShot (click);
			Application.LoadLevel(0);
		}

	}
}
