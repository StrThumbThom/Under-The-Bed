using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : MonoBehaviour {

	public Transform spot;
	public kid c;
    public GameObject paper;
	bool scareFlag = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump") && (Vector3.Distance(transform.position, spot.position) < 8.0) && scareFlag == true && c.getAwake() == false)
		{

			scareFlag = false;
            c.setAwake();
		}

	}

    public void SetScare(bool t)
    {
        scareFlag = t;
    }
}
