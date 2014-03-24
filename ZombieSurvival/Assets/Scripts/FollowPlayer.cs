using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public float moveSpeed;
	public float minDist, maxDist;
	public Transform EnemyFollow;



	void Start () 
	{
	
			
	}
	
	void Update () 
	{

		transform.LookAt(player);

		if(Vector3.Distance(transform.position, player.position) < maxDist)
		{
			//EnemyFollow.GetComponent<Wander>().enabled = false;
			//EnemyFollow.GetComponent<FollowPlayer>().enabled = true;
			transform.position += transform.forward * moveSpeed * Time.deltaTime;



		}

		else
		{
			//EnemyFollow.GetComponent<Wander>().enabled = true;
			//EnemyFollow.GetComponent<FollowPlayer>().enabled = false;
		}
	
	}
}
