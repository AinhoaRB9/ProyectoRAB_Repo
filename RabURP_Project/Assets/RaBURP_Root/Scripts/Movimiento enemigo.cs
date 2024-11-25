using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoenemigo : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento del cuadrado
    public float distance = 10f; // Distancia máxima que el cuadrado puede recorrer antes de regresar

    private float startingPosition; // Posición inicial del cuadrado


    // Start is called before the first frame update
    void Start()
    {
        // Guardar la posición inicial del cuadrado
        startingPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del cuadrado de izquierda a derecha de forma infinita
        float newPosition = startingPosition + Mathf.PingPong(Time.time * speed, distance);

        // Actualizamos la posición del cuadrado
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}
