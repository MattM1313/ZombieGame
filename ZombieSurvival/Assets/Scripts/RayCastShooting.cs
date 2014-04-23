using UnityEngine;
using System.Collections;

public class RayCastShooting : MonoBehaviour {

	RaycastHit hit;
	public Transform pEffect;
	GameObject[] enemyList;

	void Update () 
	{

		enemyList = GameObject.FindGameObjectsWithTag("Enemy");
		if(enemyList.Length == 0)
		{
			Debug.Log ("You Survived");
		}
		//Debug.Log(enemyList.Length);


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
