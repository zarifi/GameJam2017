using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonGas : MonoBehaviour {

    private float timeSinceInstatiation;

    // Use this for initialization
    void Start ()
    {
        timeSinceInstatiation = Time.time;
        GetComponent<Collider2D>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time - timeSinceInstatiation > 0.8)
        {
            GetComponent<Collider2D>().enabled = true;
        }
        if (Time.time - timeSinceInstatiation > 5)
        {
            GameObject.Destroy(this.gameObject);
        }

    }
}
