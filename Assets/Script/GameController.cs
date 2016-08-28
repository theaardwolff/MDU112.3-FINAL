using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public float health = 100.0f;

	public GameObject player;

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
