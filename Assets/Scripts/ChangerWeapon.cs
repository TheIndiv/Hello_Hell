using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerWeapon : MonoBehaviour
{
	private GameObject shot;
	private GameObject las;
	private void Awake()
	{
	las = GameObject.Find("LaserGun");		
	shot = GameObject.Find("Shotgun");
	las.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			las.SetActive(false);
			shot.SetActive(true);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			las.SetActive(true);
			shot.SetActive(false);
		}

	}
}
