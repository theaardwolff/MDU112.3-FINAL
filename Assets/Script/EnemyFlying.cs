using UnityEngine;
using System.Collections;

public class EnemyFlying : EnemyBase {

	public int Shield;

	// Use this for initialization
	protected override void Start () {
		base.Start();
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}

	public override void TakeDamage(int incomingDamage)
	{
		// run the parent TakeDamage if our shield is gone
		if (Shield <= 0)
		{
			// base refers to our parent class (ie. Turret)
			base.TakeDamage(incomingDamage);
		}
		else
		{
			Shield -= incomingDamage;
		}
	}
}
