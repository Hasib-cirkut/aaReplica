using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject Pin;
	

	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(Pin, transform.position, Quaternion.identity);
		}
		
	}
}
