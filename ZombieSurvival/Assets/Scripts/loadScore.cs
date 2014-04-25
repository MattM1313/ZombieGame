using UnityEngine;
using System.Collections;

public class loadScore : MonoBehaviour {
	public GUIText gTxt;
	int GameOverScore;
	void Start () 
	{
		GameOverScore = PlayerPrefs.GetInt("Score");
		gTxt.text = "You Eliminated All The Enemies in: " + GameOverScore + " Seconds";
	}
	
	void Update () {


	
	}
}
