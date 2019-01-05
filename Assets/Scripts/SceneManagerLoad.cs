using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLoad : MonoBehaviour {

	// Use this for initialization
	public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
