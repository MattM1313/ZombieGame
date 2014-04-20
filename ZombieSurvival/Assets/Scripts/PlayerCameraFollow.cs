using UnityEngine;
using System.Collections;

public class PlayerCameraFollow : MonoBehaviour {

	public GameObject target;
	public bool followTarget;
	public float height = 10;

	void Start () 
	{

	}
	
	void Update () 
	{
		Vector3 newPos = Vector3.Slerp(transform.position, target.transform.position, 1);
		transform.position = new Vector3(newPos.x, height, newPos.z);
	
	}
}
