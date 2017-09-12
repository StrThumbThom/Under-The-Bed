using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kid : MonoBehaviour {
	float t;
	bool isAwake;
	bool isGoingBack;
	public Transform start;
	public Transform end;
	float time;
	// Use this for initialization
	void Start () {
		isAwake = false;
		isGoingBack = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isAwake == true && isGoingBack == false) {
			t += Time.deltaTime / 5;
			transform.position = Vector3.Lerp (start.position, end.position, t);
		}
		if (transform.position == end.position) {
			isGoingBack = true;

			t = 0;
			//t += Time.deltaTime / 12;
			//transform.position = Vector3.Lerp (end.position, start.position, t);
		}
		if (isAwake == true && isGoingBack == true) {
			t += Time.deltaTime / 8;
			transform.position = Vector3.Lerp (end.position, start.position, t);
		}
		if (transform.position == start.position) {
			isAwake = false;
			t = 0;
			isGoingBack = false;
			Vector3 temp = transform.rotation.eulerAngles;
			temp.z = -90.0f;
		}

	}
	public void setAwake ()
	{
		isAwake = true;
	}
	public bool getAwake()
	{
		return isAwake;
	}
}
