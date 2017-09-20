﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{

    public GameObject spot;
    public GameObject light;
    public Text text;
    bool hidden = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetButtonUp("Fire1")))
        {
            spot = GetHidingSpot();
            if (Vector3.Distance(transform.position, spot.transform.position) < 5.0)

            {
                if (GetComponent<Hide>().hidden == false)
                {
                    GetComponent<Renderer>().enabled = false;
                    GetComponent<move>().enabled = false;
                    hidden = true;
                    spot.GetComponent<Renderer>().material.color = Color.black;


                }

                else
                {
                    GetComponent<Renderer>().enabled = true;
                    GetComponent<move>().enabled = true;
                    hidden = false;
                    spot.GetComponent<Renderer>().material.color = Color.white;

                }
            }
        }

        if(hidden == false && light.active)
        {
            GetComponent<Renderer>().material.color = Color.red;
            text.text = "GAME OVER";
        }
    }

    public GameObject GetHidingSpot()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("HidingSpot");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
