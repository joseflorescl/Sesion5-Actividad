using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int secondsToDestroy = 5; // despues de esta cantidad de segundos la bala se autodestruye
    public float speed = 5f; // velocidad de movimiento hacia adelante
    public float damage = 1f; // cantidad de da�o que recibir� el objeto con el que choque la bala

    void Start()
    {
        // Despu�s de unos segundos el objeto se autodestruye
        Destroy(gameObject, secondsToDestroy);
    }

    void Update()
    {
        // La bala se mueve hacia adelante con respecto a su eje forward local
        // porque se ocupa la direcci�n Vector3.forward y el m�todo Translate por defecto usa coordenadas locales
        Vector3 move = speed * Time.deltaTime * Vector3.forward;
        transform.Translate(move);

        // La otra forma ser�a usar:
        //Vector3 move = speed * Time.deltaTime * transform.forward;
        //transform.Translate(move, Space.World);
    }
}
