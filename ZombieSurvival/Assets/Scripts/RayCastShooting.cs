using UnityEngine;
using System.Collections;

public class RayCastShooting : MonoBehaviour {

	RaycastHit hit;
	public Transform pEffect;

	void Update () 
	{




		if(Input.GetButtonDown("Fire1"))
		{
			if(Physics.Raycast(transform.position, transform.forward, out hit, 100))
			{
				if(hit.collider.gameObject.CompareTag("Enemy"))
				{
					//Debug.DrawRay(transform.position, transform.forward, Color.red);
					Transform particleTemp = Instantiate(pEffect, hit.point, Quaternion.LookRotation(hit.normal)) as Transform;
					Destroy(hit.collider.gameObject);





				}

			}



		}


	
	}
}
