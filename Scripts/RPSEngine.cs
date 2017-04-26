using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RPSEngine : MonoBehaviour {

	string [] select = new string[3]  { "Rock",  "Paper", "Scissor" };

	int userSelection;
	int aiSelection;

	// Text datatype
	// 0: winner, 1: compare, 2: user select, 3: ai select
	public Text [] gameText = new Text[4];

	int userScore = 0;
	int aiScore   = 0;

	public Text userScoreTxt;
	public Text aiScoreTxt;

	// RPS Table
	RPSTable rps;

	// Use this for initialization
	void Start () {
	
		this.userSelection = -1;
		this.aiSelection   = -1;

		this.userScore = 0;
		this.aiScore   = 0;

		rps = new RPSTable();
	}
	
	// Update is called once per frame
	void Update () {
	
		this.RunGame();
	}

	public void SetUserSelection(int s) {

		this.userSelection = s;

		this.gameText[2].text = this.select[userSelection];

		this.SetAISelection();
	}

	void SetAISelection() {

		int n = Random.Range(0, 3);
		this.aiSelection = n;

		this.gameText[3].text = this.select[aiSelection];
	}

	void RunGame() {

		if(this.userSelection != -1) {

			if(this.userSelection != this.aiSelection)
			{
				gameText[0].text = this.GameLogic(this.userSelection, this.aiSelection);
			}
			else {
				gameText[0].text = "Tied up";
			}

			this.gameText[1].text = this.select[userSelection] + " VS " + this.select[aiSelection];

			// reset
			this.userSelection = -1;
		}

		// Display score
		this.userScoreTxt.text = this.userScore.ToString();
		this.aiScoreTxt.text = this.aiScore.ToString();

		// End game
		if(this.userScore > 5) {
			Application.LoadLevel("Win");
		}
		else if(this.aiScore > 5){
			Application.LoadLevel("Lose");
		}
	}

	string GameLogic(int u, int a) {

		string ky = u.ToString() + a.ToString();


		if(rps.Scoring(ky) == "A") {
			this.userScore++;
		}
		else {
			this.aiScore++;
		}
		/*
		// user select Rock
		if(u == 0 && a == 1) {
			this.aiScore++;
			return "Computer point";
		}
		else if(u == 0 && a == 2) {
			this.userScore++;
			return "You point";
		}

		// user select Paper
		if(u == 1 && a == 2) {
			this.aiScore++;
			return "Computer point";
		}
		else if(u == 1 && a == 0) {
			this.userScore++;
			return "You point";
		}

		// user select Scissor
		if(u == 2 && a == 0) {
			this.aiScore++;
			return "Computer point";
		}
		else if(u == 2 && a == 1) {
			this.userScore++;
			return "You point";
		}
		*/

		return rps.GetTable(ky);
	}












}
