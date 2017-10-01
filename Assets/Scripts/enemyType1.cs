using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyType1 : MonoBehaviour {

	private Vector3 frometh;
	//private Vector3 untoeth;
	float speed = 0.04f;
	//private float secondsForOneLength = 0.2f;

	void Start()
	{
		frometh = transform.position;
		//untoeth = new Vector3(transform.position.x, transform.position.y - 3, 0);
	}

	void Update()
	{
		transform.Translate(new Vector3(-0.04f, speed, 0));
		if (transform.position.y - frometh.y >= 1.5)
			speed *= -1;
		if (transform.position.y - frometh.y <= -1.5)
			speed *= -1;

        if (transform.position.x <= -12.5)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

	void Move()
	{
		//transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
	}
}
