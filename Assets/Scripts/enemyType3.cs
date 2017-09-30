using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyType3 : MonoBehaviour {

	public float maxSize = 12;
	public float growFactor = 1;
	public float waitTime = 0;


	private Vector3 frometh;
	//private Vector3 untoeth;
	float speed = 0.05f;
	//private float secondsForOneLength = 0.2f;

	void Start()
	{
		StartCoroutine(Scale());

		frometh = transform.position;
		//untoeth = new Vector3(transform.position.x, transform.position.y - 3, 0);
	}

	void Update()
	{
		transform.Translate(new Vector3(-0.04f, speed, 0));
		if (transform.position.y - frometh.y >= 4)
			speed *= -1;
		if (transform.position.y - frometh.y <= -4)
			speed *= -1;

	}

	void Move()
	{
		//transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
	}
	IEnumerator Scale()
	{
		float timer = 0;

		while(true) // this could also be a condition indicating "alive or dead"
		{
			// we scale all axis, so they will have the same value, 
			// so we can work with a float instead of comparing vectors
			while(maxSize > transform.localScale.x)
			{
				timer += Time.deltaTime;
				transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
				yield return null;
			}
			// reset the timer

			yield return new WaitForSeconds(waitTime);

			timer = 0;
			while(1 < transform.localScale.x)
			{
				timer += Time.deltaTime;
				transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
				yield return null;
			}

			timer = 0;
			yield return new WaitForSeconds(waitTime);
		}
	}
}
