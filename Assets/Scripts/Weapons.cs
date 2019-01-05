using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {
    GameObject shotgun;
    GameObject laser;
	// Use this for initialization
	void Awake () {
        shotgun = GameObject.FindGameObjectWithTag("Shotgun");
        laser = GameObject.FindGameObjectWithTag("LaserGun");
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            shotgun.SetActive(true);
            laser.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            shotgun.SetActive(false);
            laser.SetActive(true);
        }
    }
}
