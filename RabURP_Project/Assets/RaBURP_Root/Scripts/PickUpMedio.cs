using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMedio : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama al sistema de puntuación
            ScoreManager.Instance.AddPoints(2);
            // Destruye el PickUp
            Destroy(gameObject);

            if (other.CompareTag("Player"))
            {
                Debug.Log("¡El Player tocó el PickUp!");
                Destroy(gameObject);
            }
        }

    }
}
