using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Satij 
// March 15, 2023

/// <summary>
    // For the movement to work make sure you add the "Ground" to collider or your ground Object, or it will throw a error.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Player movement speed
    public float jumpHeight = 5f; // Player jump height
    private bool isGrounded = false; // Flag to check if the player is on the ground
    private Rigidbody2D rb; // Reference to the player's rigidbody component
    public Animator animator; // Reference to the player's animator component
    private Vector3 originalScale;
    private SpriteRenderer spriteRenderer; // Reference to the

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the player's rigidbody component
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;//Freeze the rotation of player
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get horizontal movement input (left/right arrow keys)
        Vector2 movement = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y); // Create a 2D vector with the player's movement direction
        rb.velocity = movement; // Set the player's velocity to the movement vector
        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal * moveSpeed)); // Set the player's velocity to the movement vector
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("IsJumping",true);
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight); // Set the player's vertical velocity to the jump height when they jump
            isGrounded = false; // Set the isGrounded flag to false to prevent double jumping
        }
    

         if (moveHorizontal > 0) // If the player is moving right face right 
         {
          this.spriteRenderer.flipX = false;
         }
         else if (moveHorizontal < 0) // If the player is moving left face left
         {
            this.spriteRenderer.flipX = true;
         }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("IsJumping", false);//sets bool to flase in animator 
            isGrounded = true; // Set the isGrounded flag to true when the player collides with the ground
        }
    }
}