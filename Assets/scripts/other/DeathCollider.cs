using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Keegan 5/3/2023-_/__/2023 WIP Do not connect to anything unless its a test level



public class DeathCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) // Use "Collider2D" instead of "Collider" for 2D games
    {
        if (other.CompareTag("Player")) 
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
