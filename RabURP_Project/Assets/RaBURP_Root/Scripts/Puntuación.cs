using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuación : MonoBehaviour
{
    public Text scoreText; // Referencia al componente Text donde se mostrarán los puntos
    private int score = 0; // Puntuación inicial

    // Método para incrementar los puntos
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Método para actualizar el texto en pantalla con la puntuación actual
    private void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Asegurarnos de que el texto se actualice desde el inicio
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
