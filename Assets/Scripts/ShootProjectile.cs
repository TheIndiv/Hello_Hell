using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
	private float timer = 0f;
	private GameObject player;
	public GameObject pocisk;
    int rand;
	private void Start()
	{
		player = GameObject.Find("Player");
       rand= UnityEngine.Random.RandomRange(4, 10);
    }

	private void Update()
	{
		if (timer < rand)
		{
			timer += Time.deltaTime;
		}
		else
		{
			timer = 0;
			Shoot();
            rand = UnityEngine.Random.RandomRange(1, 4);
        }
	}

	void Shoot()
	{
		Vector3 positionOfPlayer = player.transform.position;
		float distanceBetweenObjects = Vector2.Distance(positionOfPlayer, transform.position);
		
			Vector3 direction = (player.transform.position - transform.position) / distanceBetweenObjects;
			Vector3 vectorOfThePlaceBehindPlayer = direction * 4 + positionOfPlayer;
			GameObject proj = Instantiate(pocisk, pocisk.transform.position, pocisk.transform.rotation);
			proj.GetComponent<LittleScriptForBullet>().firstBullet = false;
			proj.transform.localScale = new Vector3(1, 1, -1);
			Destroy(proj, 4);
		
	}
}
