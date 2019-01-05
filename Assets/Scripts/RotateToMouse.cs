using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
	public Camera cam;

	public float maximumLength;

	private Ray rayMouse;

	private Vector3 pos;

	private Vector3 direction;

	private Quaternion rotation;
	// Use this for initialization
	
	// Update is called once per frame

	void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
		direction = destination - obj.transform.position;
		rotation = Quaternion.LookRotation(direction);
		obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
	}
}
