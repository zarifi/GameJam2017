using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public GameObject Lasers;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Button;
    public GameObject Turret;
    public GameObject PoisonGas;
    public GameObject Background;

    bool stop = false;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        Instantiate(Lasers);
        yield return new WaitForSeconds(1);
        Instantiate(PoisonGas, new Vector3(-Random.Range(-10.2f, 10.2f), Random.Range(-4, 4), 0), Quaternion.identity);
        Instantiate(Enemy1, new Vector3 (13, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        Instantiate(Turret);
        Background.GetComponent<Renderer>().material.color = Color.green;
        yield return new WaitForSeconds(3);
        Instantiate(Enemy1, new Vector3(13, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(Turret);
        Instantiate(PoisonGas, new Vector3(-Random.Range(-10.2f, 10.2f), Random.Range(-4, 4), 0), Quaternion.identity);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy1, new Vector3(13, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(PoisonGas, new Vector3(-Random.Range(-10.2f, 10.2f), Random.Range(-4, 4), 0), Quaternion.identity);
        Background.GetComponent<Renderer>().material.color = Color.cyan;
        yield return new WaitForSeconds(1.5f);
        Instantiate(Lasers);
        yield return new WaitForSeconds(2);
        Instantiate(PoisonGas, new Vector3(-Random.Range(-10.2f, 10.2f), Random.Range(-4, 4), 0), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(13, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        yield return new WaitForSeconds(2.2f);
        Instantiate(Enemy1, new Vector3(13, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        Instantiate(Turret);
        yield return new WaitForSeconds(1.5f);
        Instantiate(PoisonGas, new Vector3(-Random.Range(-10.2f, 10.2f), Random.Range(-4, 4), 0), Quaternion.identity);
        Instantiate(Lasers);        
        yield return new WaitForSeconds(2);
        Background.GetComponent<Renderer>().material.color = Color.red;
        Instantiate(Button);
    }

    // Update is called once per frame
    void Update ()
    {
     
    }
}
