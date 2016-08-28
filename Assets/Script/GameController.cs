using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public float health = 100.0f;

	public GameObject player;

	public static GameController Instance;

	void Awake()
	{
		Instance = this;
	}

	// End of block to make this a singleton
	// ------------------------------------------------------------------------

	private int NumEnemiesActive = 0;

	public void RegisterEnemy()
	{
		NumEnemiesActive += 1;
		UIController.Instance.SetNumberOfEnemies(NumEnemiesActive);
	}

	public void DeregisterEnemy()
	{
		NumEnemiesActive -= 1;
		UIController.Instance.SetNumberOfEnemies(NumEnemiesActive);
	}


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

	}

	public void takeDamage(float dmg){
		health -= dmg;

		if (health <= 0)
			Destroy (this.gameObject);    
	}
		
	public void LoadScene (){

		Application.LoadLevel ("GameLevel");
	}

}
