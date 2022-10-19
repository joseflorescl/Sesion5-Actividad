using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Esta clase es usada por el script WallController

    public float maxHealth = 10f;
    float health;

    void Start()
    {
        health = maxHealth;
    }

    public void Damage(float damage)
    {
        // Se le quita salud al objeto y se valida si se le acaba para destruirlo.
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }

}
