using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	// ------------------------------------------------------------------------
	// Begin of block to make this a singleton

	public static UIController Instance;

	void Awake()
	{
		Instance = this;
	}

	// End of block to make this a singleton
	// ------------------------------------------------------------------------

	public EnemyCountDisplay enemyCountDisplay;

	public void SetNumberOfEnemies(int newNumEnemies)
	{
		enemyCountDisplay.SetNumberOfEnemies(newNumEnemies);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
