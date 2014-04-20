using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float speed = 5;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Plane playerPlane = new Plane(Vector3.up, transform.position);

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


		float hitLength = 0.0f;

		if(playerPlane.Raycast(ray, out hitLength))
		{
			Vector3 target = ray.GetPoint(hitLength);

			target = target - transform.position;

			Quaternion targetRotation = Quaternion.LookRotation(target);

			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

			//Debug.DrawRay(transform.position, transform.forward*5, Color.red, 0, true);

		}


	
	}
}
