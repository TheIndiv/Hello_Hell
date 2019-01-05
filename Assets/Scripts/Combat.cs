using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class Combat : MonoBehaviour
{
	private Animator anim;
	private GameObject projectile;
	public float timer = 0;

	float damage = 10f;

	private float range = 10f;

	public ParticleSystem muzzleFlash;
	// Use this for initialization
	void Start ()
	{
		projectile = GameObject.Find("Pocisk");
		anim = GetComponentInChildren<Animator>();
		muzzleFlash = GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		{
			anim.SetBool("Shoot", true);
			Shoot();
		}
		
	}

	void Shoot()
	{
		GameObject projectile;


	}
}
