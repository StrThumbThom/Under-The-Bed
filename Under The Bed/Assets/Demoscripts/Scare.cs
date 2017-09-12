using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : MonoBehaviour {

	public Transform spot;
	public kid c;
	bool scareFlag1 = true;
	bool scareFlag2 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.J)) && (Vector3.Distance(transform.position, spot.position) < 8.0) && scareFlag1 == true && c.getAwake() == false)
		{

			scareFlag1 = false;
			scareFlag2 = true;
			c.setAwake ();

		}
		if ((Input.GetKeyDown(KeyCode.K)) && (Vector3.Distance(transform.position, spot.position) < 8.0) && scareFlag2 == true && c.getAwake() == false)
		{

			scareFlag1 = true;
			scareFlag2 = false;
			c.setAwake ();
		}

	}
}
