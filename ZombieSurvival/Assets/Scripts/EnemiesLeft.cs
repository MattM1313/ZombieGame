using UnityEngine;
using System.Collections;

public class EnemiesLeft : MonoBehaviour {

	public GUIText gText;
	GameObject[] enemyList;

	void Start () {
	
	}
	

	void Update () 
	{
		enemyList = GameObject.FindGameObjectsWithTag("Enemy");
		gText.text = "Enemies Left:" + enemyList.Length;


	}
}
