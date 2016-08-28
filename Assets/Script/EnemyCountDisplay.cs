using UnityEngine;
using System.Collections;

public class EnemyCountDisplay : MonoBehaviour {
	private UnityEngine.UI.Text textDisplay;

	public void SetNumberOfEnemies(int newNumEnemies)
	{
		textDisplay.text = "Num Enemies: " + newNumEnemies.ToString();
	}

	// Use this for initialization
	void Awake () {
		textDisplay = gameObject.GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

	}
}