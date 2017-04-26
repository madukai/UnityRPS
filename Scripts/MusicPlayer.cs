using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Static variable
	// Singleton
	static MusicPlayer instance = null;

	// Use this for initialization
	void Start () {
		// Check if an instance exist
		if(instance != null) {
			Destroy(gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
