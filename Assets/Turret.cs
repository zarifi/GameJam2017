using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.05f * Vector3.left, Space.World);
        transform.LookAt(player.transform);
        transform.Rotate(new Vector3(0, 90, 0));
    }
}
