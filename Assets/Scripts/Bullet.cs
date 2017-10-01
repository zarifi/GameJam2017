using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Vector3 direction;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.1f * Vector3.left);
    }



    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}