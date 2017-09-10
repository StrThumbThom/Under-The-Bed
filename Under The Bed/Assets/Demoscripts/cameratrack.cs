using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratrack : MonoBehaviour {

     public Transform target;
	
	// Update is called once per frame
	void Update () {
        Vector3 truetarg = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.LookAt(truetarg);
	}
}
