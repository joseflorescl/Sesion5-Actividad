using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject bulltePrefab; // El prefab de la bala
    public Transform firePoint; // El transform desde donde se crear� la bala

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // La bala se posiciona en donde est� el objeto firePoint, pero adem�s se usa la direcci�n de ese objeto.
            // En caso que el Ca��n rote, como el objeto firePoint es hijo, tambi�n rotar�.
            Instantiate(bulltePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
