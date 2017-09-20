using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kid : MonoBehaviour {
	float t;
	bool isAwake;
	bool isGoingBack;
    bool wait;
    bool arrived;
	public Transform start;
	public Transform end;
    public GameObject light;
    public Text countdown;
	float time;
	// Use this for initialization
	void Start () {
		isAwake = false;
		isGoingBack = false;
        wait = false;
        arrived = false;
        light.SetActive(false);
        countdown.text = "";
	}
	
	// Update is called once per frame
	void Update () {

        if(wait)
        {
            t += Time.deltaTime;

            int remainingtime = (int)(5 - t);
            countdown.text = remainingtime.ToString(); 

            if(remainingtime == 0)
            {
                wait = false;
                isGoingBack = true;
                t = 0;
                countdown.enabled = false;
            }
        }

		if (isAwake == true && isGoingBack == false && wait == false) {
			t += Time.deltaTime;
			transform.position = Vector3.Lerp (start.position, end.position, t);
            transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		if (transform.position == end.position) {
            wait = true;

            if(!arrived)
            {
                t = 0;
                arrived = true;
                countdown.enabled = true;
            }
		}
		if (isAwake == true && isGoingBack == true) {
			t += Time.deltaTime / 8;
			transform.position = Vector3.Lerp (end.position, start.position, t);
            light.SetActive(true);
            countdown.text = "";

        }
        if (transform.position == start.position) {
			isAwake = false;
            arrived = false;
			t = 0;
            isGoingBack = false;
            light.SetActive(false);
            transform.rotation = Quaternion.Euler(0, 0, -90f);
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
