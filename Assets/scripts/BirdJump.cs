using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f; 
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component from the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for left mouse button click or space key press
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            // Set Rigidbody2D velocity to make the bird jump
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void FixedUpdate() 
    {
        // Adjust the rotation based on the bird's vertical velocity
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        GameManager.instance.GameOver();
    }
}
