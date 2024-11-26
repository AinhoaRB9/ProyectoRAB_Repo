using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama al sistema de puntuación
            ScoreManager.Instance.AddPoints(1);
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
