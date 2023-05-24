using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomScript : MonoBehaviour
{
    public float jumpBoostPower = 50;
    public Rigidbody2D otherRBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("Player"))
        {
            otherRBody = otherObject.GetComponent<Rigidbody2D>();
            //otherRBody.AddForce(0, 0, jumpBoostPower, ForceMode2D.Impulse);
        }
    }
}
