using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class LittleScriptForBullet : MonoBehaviour
{
	public int bulletSpeed = 70;
	public bool firstBullet =  true;
	void Update()
	{
		if(!firstBullet)
			transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
	}
}
