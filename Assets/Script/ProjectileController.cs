using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {
	
	// Float that indicates how long the projectile will exist for
	public float lifespan = 5f;

	// Float that indicates how long the projectile has left to live
	protected float timeRemaining = 0f;


	// Use this for initialization
	void Start () {
		
		timeRemaining = lifespan;
	}

	// Update is called once per frame
	void Update () {

		//If The time remaining is higher than 0...
		if (timeRemaining > 0)
		{
			// ...update the current time remaining
			timeRemaining -= Time.deltaTime;

			//if the time remaining is under or equal to 0...
			if (timeRemaining <= 0)
			{
				//...destroy the projectile
				Destroy(gameObject);
			}
		}
	}
}