using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] private float normalSpeed;
    [SerializeField] private float livespan;

    public bool isAlive;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;

        SetVelocity();
    }
    private void Update()
    {
        SetVelocity();
        WaitAndDestroy();
    }


    private void SetVelocity()
    {
        rb.velocity = transform.up * normalSpeed;
    }

    private void WaitAndDestroy()
    {
        GameObject.Destroy(gameObject, livespan);
    }
}
