using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scare : MonoBehaviour {

	public Transform spot;
	public kid c;
    public Slider slide;
    public Text win;
    public Hide hide;
	bool scareFlag = true;
	// Use this for initialization
	void Start () {
        slide.value = 0;
        win.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump") && (Vector3.Distance(transform.position, spot.position) < 8.0) && scareFlag == true && c.getAwake() == false)
		{

			scareFlag = false;
            c.setAwake();
            slide.value += 1;
		}

        if(slide.value == 2 && hide.IsAlive() && c.getAwake() == false)
        {
            win.enabled = true;
        }
	}

    public void SetScare(bool t)
    {
        scareFlag = t;
    }
    public bool GetScare()
    {
        return scareFlag;
    }
}
