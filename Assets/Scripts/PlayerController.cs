using System;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public int health = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector2 movement = new Vector2(horizontal, vertical).normalized * speed;
        if (movement != Vector2.zero)
        {
            rb.linearVelocity = movement;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
