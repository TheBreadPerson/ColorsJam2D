using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float hoz;
    bool isGrounded;
    [SerializeField] private float Speed, JumpForce, Radius;
    [SerializeField] private LayerMask Ground;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hoz = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, Radius, Ground);
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(hoz * Speed, rb.velocity.y);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * JumpForce);
    }
}
