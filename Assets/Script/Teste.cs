using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float x, z;
    float velocidade;
    LineRenderer lr;
    Rigidbody rb;


    void Start()
    {
        lr = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            Debug.Log("");

    }

    void Update()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, new Vector3(transform.position.x - x,
            transform.position.z + z));
        if (Input.GetButtonDown("Jump") && lr.enabled)
        {
            rb.AddForce(new Vector3(2 * x, 0, 2 * z), ForceMode.Impulse);
            lr.enabled = false;
          //  if (GameManager.gm) { 
             //   GameManager.gm.tacada();
          //  }

        }
        velocidade = rb.velocity.magnitude;
        if (velocidade < 0.05f)
        {

            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            lr.enabled = true;
        }
        else
        {
            lr.enabled = false;
        }
    }
}