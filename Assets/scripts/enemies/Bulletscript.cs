using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bulletscript : MonoBehaviour
{
	private GameObject player;
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

	void OnCollisionEnter2D(Collision2D otherObject)
	{
		// if this laser collided with the layet
		if (otherObject.gameObject.CompareTag("Player"))
		{
			// makes the player lose
			player = GameObject.FindWithTag("Player");  //finds player
			player.GetComponent<SpriteRenderer>().flipY = true;  //flips player upside down
			player.GetComponent<BoxCollider2D>().enabled = false;   //turns players collider off
			player.GetComponent<PlayerMovement>().notLose = false;   //restricts movement
			player.GetComponent<Timer>().stillAlive = false;


			SceneManager.LoadSceneAsync("LoseScene", LoadSceneMode.Additive);

			Scene currentScene = SceneManager.GetActiveScene();
			int sceneNum = currentScene.buildIndex;
			if (sceneNum == 1)
			SceneManager.UnloadSceneAsync("InLevel");
			
		}
	}

	
	
}
