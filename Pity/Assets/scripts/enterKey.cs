using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class enterKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( KeyCode.Return ) ) {
			//if the t key is hit
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}
}
}
