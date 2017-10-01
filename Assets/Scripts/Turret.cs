using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject player;
    public GameObject bullet;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.05f * Vector3.left, Space.World);
        if (player!= null)
        {
            transform.LookAt(player.transform);
            transform.Rotate(new Vector3(0, 90, 0));
        }                
        if (transform.position.x <= -12.5)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(2);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(2);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}
