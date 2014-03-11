using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public Transform t;
	public Camera camera;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Plane playerPlane = new Plane(Vector3.up, t.position);
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		float hitLength = 0.0f;

		if(playerPlane.Raycast(ray, out hitLength))
		{
			Vector3 target = ray.GetPoint(hitLength);
			target = target - t.position;

			Quaternion targetRotation = Quaternion.LookRotation(target);
			t.rotation = targetRotation;
		}
	
	}
}
