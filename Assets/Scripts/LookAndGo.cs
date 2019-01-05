using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndGo : MonoBehaviour {

	private GameObject player;
	private Rigidbody rb;
	public bool look = true;
	public bool goAfter = true;
	public int movementSpeed = 5;
	void Start ()
	{
		player = GameObject.Find("Player");
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		Vector3 playerPos = player.transform.position;
		float distanceBetween = Vector3.Distance(playerPos, transform.position);
		Vector3 direction = (player.transform.position - transform.position) / distanceBetween;
		if (look)
		{
			Quaternion elo = Quaternion.LookRotation(direction, Vector3.zero);
			transform.rotation = elo;
		}

		if (goAfter)
		{
			transform.position += transform.forward * movementSpeed * Time.deltaTime;
		}
	
	}

	
}
