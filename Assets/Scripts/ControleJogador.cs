using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{

    private Rigidbody rb;
    public float velocidade;
    private bool pulando = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float pulo = 0;
        if (Input.GetKey(KeyCode.Space) && pulando == false)
        {
            pulo = 50;
            pulando = true;
        }
        Vector3 mov = new Vector3(h, pulo, v);
        rb.AddForce(mov * velocidade);
    }

    void OnCollisionEnter(Collision col)
    {
        pulando = false;
    }
}
