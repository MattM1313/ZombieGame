using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5;
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis("Horizontal")  * speed;
		float y = Input.GetAxis("Vertical")  * speed;
		rigidbody.velocity = new Vector3(-x,0,-y);

	}
}
