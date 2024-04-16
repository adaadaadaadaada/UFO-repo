using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int damage = 1;

    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;

        
    }

    private void Update()
    {
        
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        print("damage");

        if (currentHealth > 0)
        {

        }
        else
        {
            // lose
        }

    }
}
