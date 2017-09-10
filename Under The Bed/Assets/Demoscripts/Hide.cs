using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    public Transform spot;
    public GameObject a;
    bool hidden = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetButtonUp("Fire1")) && (Vector3.Distance(transform.position, spot.position) < 5.0))
        {
            if(GetComponent<Hide>().hidden == false)
            {
                GetComponent<Renderer>().enabled = false;
                GetComponent<move>().enabled = false;
                hidden = true;

            }

            else
            {
                GetComponent<Renderer>().enabled = true;
                GetComponent<move>().enabled = true;
                hidden = false;
            }
        }

    }
}
