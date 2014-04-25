using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	public string buttonName = "";

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 200, 100, 50),"Start"))
		{
			Application.LoadLevel(0);
		}

		if(GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 140, 100, 50),"Stuff"))
		{
			Application.LoadLevel(2);
		}

		if(GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 80, 100, 50),"Quit"))
		{
			Application.Quit();
		}




	}
}
