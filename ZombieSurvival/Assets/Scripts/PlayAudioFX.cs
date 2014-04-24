using UnityEngine;
using System.Collections;

public class PlayAudioFX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public AudioClip[] myClip;
	
	void Update () {
		
		audio.clip = myClip[Random.Range(0,myClip.Length)];
		
		audio.Play();

}
}
