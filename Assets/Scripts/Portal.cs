using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    BoxCollider bc;
    private void Start()
    {
        bc = GetComponent<BoxCollider>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player")
        SceneManager.LoadScene(2);
    }
    // Use this for initialization
  
	
}
