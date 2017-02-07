using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class audio : MonoBehaviour {

	bool AudioBegin = false; 

	void Awake()
	{
		if (!AudioBegin) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
//	void Update () {
//		if(Application.loadedLevelName == "pity")
//		{
//			AudioSource audio = GetComponent<AudioSource>();
//			audio.Stop();
//			AudioBegin = false; 
//		}
//	}
}
