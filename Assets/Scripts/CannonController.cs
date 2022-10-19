using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject bulltePrefab; // El prefab de la bala
    public Transform firePoint; // El transform desde donde se creará la bala

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // La bala se posiciona en donde está el objeto firePoint, pero además se usa la dirección de ese objeto.
            // En caso que el Cañón rote, como el objeto firePoint es hijo, también rotará.
            Instantiate(bulltePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
