using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller1 : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento básico del Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detectado con: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("¡El Player tocó el PickUp!");
            Destroy(gameObject);
        }
    }
}

