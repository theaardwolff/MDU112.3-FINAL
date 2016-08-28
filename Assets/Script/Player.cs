using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public float health = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void takeDamage(float dmg){
		health -= dmg;

		if (health <= 0)
			Destroy (this.gameObject);   
	}
}
