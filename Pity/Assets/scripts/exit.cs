using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider other) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);

	}
}
