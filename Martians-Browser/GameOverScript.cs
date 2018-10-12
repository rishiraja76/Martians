using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour 
{

	int score =0;
	public AudioClip click;

	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");

		if(score > PlayerPrefs.GetInt("highscore"))
		{
			PlayerPrefs.SetInt("highscore",score);
		}
	}



	void OnGUI()
	{
	
		GUI.Label (new Rect (Screen.width / 2 - 40, 250, 300, 30), "Your Score: " + score);
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 300, 30), "High Score: " + PlayerPrefs.GetInt("highscore"));
		if(GUI.Button(new Rect (Screen.width / 2 - 25, 375, 60, 30), "Retry?"))
		{
	    
			Application.LoadLevel(0);
			GetComponent<AudioSource>().PlayOneShot(click);
		}
	}  
}