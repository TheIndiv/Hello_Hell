using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour {
	
	// Use this for initialization
	public float health = 50f; 
	private GameObject player;
	void Start ()
	{
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{	
		
		Vector3 playerPos = player.transform.position;
		float distanceBetween = Vector3.Distance(playerPos, transform.position);
		Vector3 direction = (player.transform.position - transform.position) / distanceBetween;
		direction.y = 0;
		Quaternion elo =  Quaternion.LookRotation(direction, Vector3.zero);
	//w	transform.rotation = elo;
		transform.Translate(direction * 2 * Time.deltaTime);
		elo.x = 0;
	}

	public void TakeDamage(float amount)
	{
		health -= amount;
		if (health <= 0f)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(gameObject);
	}
}
