using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class UfoMovement : MonoBehaviour
{
    public static bool hasHitBottomScreen = false;

    public UImanager uimanager;

    public Health health;

    public Animator animator;

    private Rigidbody2D rb;

    [SerializeField] private float damage = 1.0f;

    private void Start()
    {
        uimanager = GameObject.FindAnyObjectByType<UImanager>();
        health = GameObject.FindAnyObjectByType<Health>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = GetComponent<Health>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (0f, -2f) * Time.deltaTime);
    }

    private void Update()
    {
        float z = Mathf.PingPong(t: Time.time, length: 2f); Vector3 axis = new Vector3(0, 0, 1); transform.Rotate(axis, angle: 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BottomScreen"))
        {
            UImanager.ufoCount -= 1;
            hasHitBottomScreen = true;

            print("ufo osu alas");
            print("ufocount " + UImanager.ufoCount);

            Destroy(gameObject);

            if (UImanager.ufoCount == 0)
            {
                if (UfoMovement.hasHitBottomScreen == true)
                {
                    print("ufo has hit bottomn screen");
                    health.TakeDamage(damage);
                }
            }
        }

        if (collision.CompareTag("Projectile"))
        {
            animator.SetBool("hit", true);
            Destroy(gameObject, 0.1f);

            //ufo 1 = 1p, ufo 2 = 2p
        }
    }
}
