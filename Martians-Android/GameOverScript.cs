using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour 
{
	public GUIText score;
	public GUIText highscore;
	public AudioClip click;

	void Start () 
	{
		int score = PlayerPrefs.GetInt ("Score");

		if(score > PlayerPrefs.GetInt("highscore"))
		{
			PlayerPrefs.SetInt("highscore",score);
		}

	}

	void Update () 
	{
		score.text = "Your Score: " + PlayerPrefs.GetInt ("Score");
		highscore.text = "Highscore: "+ PlayerPrefs.GetInt("highscore");
	}

	//void OnGUI()
	//{

		//GUI.Label (new Rect (Screen.width / 2 - 40, 250, 300, 30), "Your Score: " + score);
		//GUI.Label (new Rect (Screen.width / 2 - 40, 300, 300, 30), "High Score: " + PlayerPrefs.GetInt("highscore"));
		//if(GUI.Button(new Rect (Screen.width / 2-20, 350, 60, 30), "Retry?"))
		//{
			//Application.LoadLevel(0);
			//audio.PlayOneShot(click);
		//}
	//}  
}