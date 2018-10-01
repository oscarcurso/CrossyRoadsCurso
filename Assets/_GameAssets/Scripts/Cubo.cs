using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {


    AudioSource AudioSource;
    
    // Use this for initialization
    void Start () {
        AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        

    }

    private void OnTriggerEnter(Collider other)
        {

        AudioSource.Play();
        Invoke("DestruirObjeto", 3);
        
        }
        void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
