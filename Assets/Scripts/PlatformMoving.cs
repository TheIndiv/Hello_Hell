using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.WebCam;

public class PlatformMoving : MonoBehaviour
{
	public enum way
	{
		up,
		down,
		stop,
	}

	private Vector3 startPos;

	public way now;
	public float maxHeight = 10;
	
	public float speed = 3;

	public Vector3 direction;

	private bool directionChanged = false;

	public float timer = 0;
	// Use this for initialization
	void Start ()
	{
		now = way.up;
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		if (now == way.up)
		{
			direction = Vector3.up * Time.deltaTime;
		}
		else if (now == way.down)
		{
			direction = Vector3.down * Time.deltaTime;
		}

		transform.Translate(direction* speed);
		if((transform.localPosition.y > (startPos.y + maxHeight) ||(transform.localPosition.y < (startPos.y)))&& now != way.stop)
		{
			if (now == way.up)
			{
				now = way.down;
			}
			else if (now == way.down)
			{
				now = way.up;
			}
		}
		

		
	}
}
