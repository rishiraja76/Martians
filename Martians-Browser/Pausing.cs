using UnityEngine;
using System.Collections;

public class Pausing : MonoBehaviour {

    bool isPaused;
	public AudioClip click;
	public Texture buttonTexture;

void Start ()
{
	isPaused = false;
}

void OnGUI ()
{ 
		GUI.backgroundColor = Color.clear;
	
	if (!isPaused)
	{
			if (GUI.Button( new Rect(900,11,55,55), buttonTexture))
		{
			Time.timeScale = 0f;
			isPaused = true;
				GetComponent<AudioSource>().PlayOneShot(click);
		}
	}
	if (isPaused)
	{
			if (GUI.Button( new Rect(900,11,55,55), ""))
		{
			Time.timeScale = 1.0f;
			isPaused = false;
				GetComponent<AudioSource>().PlayOneShot(click);
		}
	}
}

}