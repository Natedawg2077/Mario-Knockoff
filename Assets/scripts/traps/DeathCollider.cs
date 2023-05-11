using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Keegan 05/03/2023-05/04/2023 



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

    private void OnCollisionEnter2D(Collision2D otherObject) // Use "Collider2D" instead of "Collider" for 2D games
    {
        string otherTag = otherObject.gameObject.tag;

        if (otherTag.Equals("Player")) 
        {
            
            SceneManager.LoadScene("Menu");
           
        }
    }
}
