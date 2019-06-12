using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private int count;
	public Text txtCount;
	public Text txtWinner;


	void Start() {
		count = 0;
		txtCount.text = "Score: 0";
		txtWinner.text = "";
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "PowerCell")
		{
			other.gameObject.SetActive (false);
			count++;
			txtCount.text = "Score: " + count.ToString();

			if (count >= 3) {
				txtWinner.text = "WINNER!";
			}
		}
	}
}
