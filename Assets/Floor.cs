using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    public GameObject f0;
    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;
    public GameObject f5;
    public GameObject f6;
    public GameObject f7;
    public GameObject f8;
    public GameObject f9;
    public GameObject f10;
    public GameObject f11;
    public GameObject f12;
    public GameObject f13;
    public GameObject f14;
    public GameObject f15;
    public GameObject f16;
    public GameObject f17;
    public GameObject f18;

    private float time = 0.5f;
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.05f * Vector3.left, Space.World);
    }

    IEnumerator Example()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            f0.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f1.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f2.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f3.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f4.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f5.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f6.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f7.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f8.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f9.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f10.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f11.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f12.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f13.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f14.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f15.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f16.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f17.transform.Translate(Vector3.right * 28.88f);
            yield return new WaitForSeconds(time);
            f18.transform.Translate(Vector3.right * 28.88f);
        }

    }
}
