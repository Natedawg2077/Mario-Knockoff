using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Keegan 05/03/2023-05/04/2023 
//Nathan 5/17/2023



public class DeathCollider : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D otherObject) // Use "Collider2D" instead of "Collider" for 2D games
    {
        player = GameObject.FindWithTag("Player");  //finds player
        player.GetComponent<SpriteRenderer>().flipY = true;  //flips player upside down
        player.GetComponent<BoxCollider2D>().enabled = false;   //turns players collider off
        player.GetComponent<PlayerMovement>().notLose = false;   //restricts movement

        //stops timer when lost
        player.GetComponent<Timer>().stillAlive = false;


        string otherTag = otherObject.gameObject.tag;
        //Changes to proper scenes
        if (otherTag.Equals("Player")) 
        {
            SceneManager.LoadSceneAsync("LoseScene", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("InLevel");
        }
    }
}
