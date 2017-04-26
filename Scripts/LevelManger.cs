using UnityEngine;
using System.Collections;

public class LevelManger : MonoBehaviour {

	public void LoadLevel(string name) {

		Application.LoadLevel(name);
	}

	public void QuitRequest() {

		Application.Quit();
	}
}
