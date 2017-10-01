using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
	//Color lightBlue = new Color(0,0,1,3);
	void Start () {
		StartCoroutine (GreenYellowRed ());
	}

	IEnumerator GreenYellowRed()
	{
		while (true) {
			//Debug.Log ("cyan");
			yield return new WaitForSeconds(5.0f);
			GetComponent<Renderer>().material.color = Color.green;
			yield return new WaitForSeconds(10.0f);
			GetComponent<Renderer>().material.color = Color.cyan;
			yield return new WaitForSeconds(10.0f);
			GetComponent<Renderer>().material.color = Color.red;
		}
	}

//	void Update()
//	{
//		ColorChangerr();
//	}


}
	
	// Update is called once per frame
	

