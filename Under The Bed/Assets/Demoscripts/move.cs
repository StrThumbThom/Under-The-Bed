using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public CharacterController test;
    public float speed;
    public Transform currentcam;
    Vector3 player;
    Vector3 cam;
    Vector3 orth;
    Vector3 toward;
    Vector3 horz;
    Vector3 vert;
    Vector3 temp;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        player = transform.position;
        cam = currentcam.position;
        toward = player - cam;
        toward.y = transform.position.y;
        toward = toward.normalized;
        orth = Vector3.Cross(toward, Vector3.up).normalized;

        horz = -orth * (Input.GetAxisRaw("Horizontal"));
        vert = toward * (Input.GetAxisRaw("Vertical"));
        temp = horz + vert;
        temp = temp.normalized * speed;
        temp.y = -1f;
        test.Move(temp);
    
	}
}
