using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour {
	public int Health;
	public int Damage;

	public enum State
	{
		Idle,
		Alert,
		Aggressive
	}

	public State currentState = State.Alert;

	// Use this for initialization
	protected virtual void Start () {
		GameController.Instance.RegisterEnemy();
	}

	// Update is called once per frame
	protected virtual void Update () {
		if (currentState == State.Alert)
		{

		}
	}

	public virtual void TakeDamage(int incomingDamage)
	{
		// apply the damage
		Health -= incomingDamage;

		// if the health is less than or equal to 0
		// destroy the game object
		if (Health <= 0)
		{
			GameController.Instance.DeregisterEnemy();

			// GameObject is a class (ie. variable type)
			// gameObject (lower case g) is a variable that refers to ourselves
			GameObject.Destroy(gameObject);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		TakeDamage(50);
	}

	public virtual void OnCollisionEnter(Collision other)
	{
		// were we hit by the player
		if (other.gameObject.GetComponent<PlayerController>() != null)
		{
			TakeDamage(25);
		}
		else
		{
			TakeDamage(50);
		}
	}
}