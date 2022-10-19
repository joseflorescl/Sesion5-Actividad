using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private HealthSystem healthSystem;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Se recupera la componente BulletController de la bala para saber el daño que se debe aplicar al muro
            BulletController bulletController = collision.gameObject.GetComponent<BulletController>();
            healthSystem.Damage(bulletController.damage);

            // Se destruye la bala
            Destroy(collision.gameObject); 
        }
    }
}
