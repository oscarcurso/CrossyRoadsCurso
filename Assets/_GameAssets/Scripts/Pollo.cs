using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {



    Rigidbody rb;
    [SerializeField] float distanciaDeteccion = 0.1f;

    [SerializeField] int fuerza = 100;
    [SerializeField] Transform posPies;


    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("space") && EstoyEnsuelo())

            

        {
          //  Collider[] cols=Physics.OverlapSphere(posPies.position, 0.1f, LayerMask.NameToLayer("Terreno"));
            //    for ( int i = 0; i <cols.Length; i++) 
              //  {
              //  Debug.Log("Estoy tocando con los pies en algo" +i);
            //}

            rb.AddForce(new Vector3(1, 1, 0) * fuerza);
        }
    

        else if (Input.GetKeyDown("z"))

        {
            rb.AddForce(new Vector3(1, 1, 1) * fuerza);
        }

        else if (Input.GetKeyDown("x"))

        {
            rb.AddForce(new Vector3(1, 1, -1) * fuerza);
        }



    }

    private bool EstoyEnsuelo()
    {

        int layerIndex = LayerMask.GetMask("Terreno");
        bool enSuelo = Physics.CheckSphere(
       
        posPies.position,
        distanciaDeteccion,
        layerIndex);
        return enSuelo;
    }

   
    
}
