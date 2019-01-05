using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.XR.WSA;

public class Shotgun : MonoBehaviour
{
    Animator anim;
	public int howManyBullets = 8;
	private List<Quaternion> bullets;
	public int spreadAngle;
	public  GameObject projectile;
	
	private bool shoot = false;
	public float timerAnimation = 0;
	private float timerShoot;
	private bool shot = true;
	void Start () {
		bullets = new List<Quaternion>(howManyBullets);
        anim = GetComponent<Animator>();
		for (int i = 0; i < howManyBullets; i++)
		{
			bullets.Add(Quaternion.Euler(Vector3.zero));
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetAxis("Fire1") == 1 && shoot == false)
		{
				shoot = true;
				shot = true;
				timerAnimation = 0;
				timerShoot = 0;           

				anim.SetBool("shoot", true);
		}
		else if (shoot == true)
		{
			if (timerAnimation > 0.05f && shot)
			{
				Shoot();
				shot = false;
			}

			if (timerAnimation < 0.7f)
			{
				timerAnimation += Time.deltaTime;
			}
			else
			{
				anim.SetBool("shoot", false);
			}

			if (timerShoot < 1f)
			{
				timerShoot += Time.deltaTime;
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
		foreach (Quaternion quat in bullets)
		{
			bullets[i] = Random.rotation;
			GameObject proj = Instantiate(projectile, projectile.transform.position, projectile.transform.rotation);
			proj.transform.rotation = Quaternion.RotateTowards(proj.transform.rotation, bullets[i], spreadAngle);
			proj.GetComponent<LittleScriptForBullet>().firstBullet = false;
			Destroy(proj,2);

		}
	}
}
