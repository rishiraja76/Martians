using UnityEngine;
using System.Collections;

public class HUDscript : MonoBehaviour 
{

   public GUIText Score;
   float playerScore = 0;


	void Update () 
    {
	    playerScore += Time.deltaTime;
		Score.text = "Score: " + (int)(playerScore * 100);
	}
	
	void OnDisable()
	{
		PlayerPrefs.SetInt("Score", (int)(playerScore * 100));

	}

	//void OnGUI()
	//{
		//GUI.Label (new Rect (10, 10, 100, 100), "Score: " + (int)(playerScore * 100));
	//}
}
