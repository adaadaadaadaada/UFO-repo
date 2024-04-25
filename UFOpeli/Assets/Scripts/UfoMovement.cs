using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.Rendering;

public class UfoMovement : MonoBehaviour
{
    public static bool hasHitBottomScreen = false;

    public GameManager gameManager;
    public UImanager uimanager;
    public Health health;
    public Animator animator;
    private Rigidbody2D rb;

    [SerializeField] private float damage = 1.0f;
    [SerializeField] private int ufoHealth;
    [SerializeField] private int ufoScore;

    private void Start()
    {
        gameManager = GameObject.FindAnyObjectByType<GameManager>();
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

            Destroy(gameObject);

            if (UImanager.ufoCount == 0)
            {
                if (UfoMovement.hasHitBottomScreen == true)
                {
                    health.TakeDamage(damage);
                }
            }
        }

        if (collision.CompareTag("Projectile"))
        {
            ufoHealth -= 1;
            UImanager.ufoCount -= 1;

            if (ufoHealth == 0)
            {
                animator.SetBool("hit", true);
                Destroy(gameObject, 0.1f);

                uimanager.score += ufoScore;

                gameManager.src.clip = gameManager.scoreSFX;
                gameManager.src.Play();
            }
        }
    }
}
