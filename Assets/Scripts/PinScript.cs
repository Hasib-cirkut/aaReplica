using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour {

	private bool isPined = false;

	private Rigidbody2D  rb;
	public float Speed;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () {

		if(!isPined)
			rb.MovePosition(rb.position + Vector2.up * Speed * Time.deltaTime);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Rotator")
		{
			isPined = true;
			transform.SetParent(col.transform);
			col.GetComponent<rotator>().rotationSpeed *= -1;
		} else if(col.tag == "Pin")
		{
			FindObjectOfType<GameManager>().EndGame();
		}

	}

}
