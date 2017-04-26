using System;
using System.Collections;

public class RPSTable
{
	public RPSTable ()
	{
		this.BuildTable();
	}

	public void BuildTable() {

		m_RPSTable = new Hashtable();

		// Rock
		m_RPSTable.Add("01", "Computer point");
		m_RPSTable.Add("02", "Player point");

		// Paper
		m_RPSTable.Add("12", "Computer point");
		m_RPSTable.Add("10", "Player point");

		// Scissor
		m_RPSTable.Add("20", "Computer point");
		m_RPSTable.Add("21", "Player point");
	}

	public string GetTable(string key) {

		return m_RPSTable[key].ToString();
	}

	public string Scoring(string key) {

		string pt = "";

		if(key == "02" || key == "10" || key == "21") {
			pt = "A";
		}
		else {
			pt = "B";
		}

		return pt;
	}

	Hashtable m_RPSTable;
}


