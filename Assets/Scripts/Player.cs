using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D MyRigidbody { get; set; }


    bool up = false;
    bool down = false;
    bool right = false;
    bool left = false;

    public GameObject deadPlayer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        if (up && this.transform.position.y <= 3.9)
        {
            this.transform.Translate(0.1f* Vector3.up);
        }

        if (down && this.transform.position.y >= -3.9)
        {
            this.transform.Translate(0.1f * Vector3.down);
        }
        if (right && this.transform.position.x <= 13)
        {
            this.transform.Translate(0.1f * Vector3.right);
        }

        if (left && this.transform.position.x >= -13)
        {
            this.transform.Translate(0.1f * Vector3.left);
        }
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
            GetComponent<Animator>().SetBool("Up", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up = false;
            GetComponent<Animator>().SetBool("Up", false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
            GetComponent<Animator>().SetBool("Down", true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down = false;
            GetComponent<Animator>().SetBool("Down", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "TheButton(Clone)")
        {
            Debug.Log("You Win");
			SceneManager.LoadScene("win", LoadSceneMode.Additive);
        }
        else
        {
            Instantiate(deadPlayer, this.transform.position, Quaternion.identity);
            GameObject.Destroy(this.gameObject);
			SceneManager.LoadScene("lose", LoadSceneMode.Additive);

        }
    }
}
