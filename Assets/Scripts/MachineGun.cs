using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour {
	private GameObject projectile;
	private bool shoot = false;
	private float timer = 0;
	void Start () {
		projectile = GameObject.Find("Pocisk");
	}
	void Update () {

		if (Input.GetAxis("Fire1") == 1 && shoot == false)
		{
			Shoot();
			shoot = true;
			timer = 0;
		}
		if (shoot == true)
		{
			if (timer < 0.1)
			{
				timer += Time.deltaTime; 
			}
			else
			{
				shoot = false;
			}
		}
	}

	void Shoot()
	{
		int i = 0;
			GameObject proj = Instantiate(projectile, projectile.transform.position, projectile.transform.rotation);
			proj.GetComponent<LittleScriptForBullet>().firstBullet = false;
			Destroy(proj,2);
	}
	
}
