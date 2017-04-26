using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	public int maxGuessesAllowed = 5;

	// Text variable
	public Text text;

	// Use this for initialization
	void Start () {
		this.StartGame ();
	}

	void StartGame () {

		max = 1000;
		min = 1;
		this.NextGuess();
	}

	public void GuessLower() {
		this.max = this.guess;
		this.NextGuess();
	}

	public void GuessHigher() {
		this.min = this.guess;
		this.NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range(min, max+1);

		this.text.text = this.guess.ToString();

		this.maxGuessesAllowed = this.maxGuessesAllowed - 1;

		if(this.maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
