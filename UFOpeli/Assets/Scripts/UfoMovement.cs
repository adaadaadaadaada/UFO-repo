using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class UfoMovement : MonoBehaviour
{
    public Animator animator;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (0f, -2f) * Time.deltaTime);
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BottomScreen"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Projectile"))
        {
            animator.SetBool("hit", true);
            Destroy(gameObject, 0.1f);
        }
    }
}
