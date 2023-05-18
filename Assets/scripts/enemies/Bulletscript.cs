using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{

	private float speed = -10.0F;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter2D(Collider2D otherObject)
	{
		// if this laser collided with the layet
		if (otherObject.gameObject.CompareTag("Player"))
		{
			// destroy the asteroid
			Destroy(otherObject.gameObject);
		}
	}

	
	
}
