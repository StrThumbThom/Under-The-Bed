using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paper : MonoBehaviour {

    public Text text;
    public Text text2;
    public Scare mon;
    public Image banan;
    public GameObject prefab;


    // Use this for initialization
    void Start () {
        GetComponent<Renderer>().material.color = Color.green;
        banan.enabled = false;
        text.enabled = false;
        text2.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        banan.enabled = true;
        text.enabled = true;
        text2.enabled = true;
        mon.SetScare(true);
    }

    private void OnTriggerExit(Collider other)
    {
        banan.enabled = false;
        text.enabled = false;
        text2.enabled = false;
        prefab.SetActive(false);
    }
}
