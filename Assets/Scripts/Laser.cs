using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    private float timeSinceInstatiation;
    public GameObject Lasers;
	// Use this for initialization
	void Start ()
    {
        timeSinceInstatiation = Time.time;
        GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Time.time - timeSinceInstatiation < 2)
        {
            if (((Time.time - timeSinceInstatiation) * 10) % 5 <= 2.5)
                GetComponent<Renderer>().enabled = false;
            else
                GetComponent<Renderer>().enabled = true;
        }
        else if (Time.time - timeSinceInstatiation < 4)
        {
            GetComponent<Renderer>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
        }

        else
        {
            GameObject.Destroy(Lasers);
        }


    }
}
