using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float moveSpeedBack = 20.0f;
	public float moveSpeedForward = 10.0f;

	public float rotateSpeedX = 50.0f;
	public float rotateSpeedY = 50.0f;

	public float cameraSpeedX = 2.0f;
	public float cameraSpeedY = 2.0f;

	public Rigidbody PlayerRb;
	public Rigidbody ProjectileRb;

	public Vector3 teleportPoint;

	public GameObject projectilePrefab;

	public GameObject[] muzzles;

	public float projectileOffset = 6f;
	public float projectileSpeed = 2000f;

	// Use this for initialization
	void Start () {

		PlayerRb = GetComponent<Rigidbody>();

	}

	//Shoot Projectiles
	/*void Shoot(){
		for (int ind = 0; ind < muzzles.Length; ++ind) {
			Instantiate (projectilePrefab, muzzles [ind].transform.position, muzzles [ind].transform.rotation);
		}
	
	}*/

	void Update () {
		rotateSpeedX += cameraSpeedX * Input.GetAxis ("Mouse X");
		rotateSpeedY -= cameraSpeedY * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3 (rotateSpeedY, rotateSpeedX, 0.0f);

		// If the shoot button is pressed down...
		if (Input.GetKeyDown (KeyCode.Space)) {

			// Create the projectile.
			GameObject projectileInstance = GameObject.Instantiate (projectilePrefab);

			// position the projectile slightly below the player.
			projectileInstance.transform.position = transform.position - transform.up * projectileOffset;

			// retrieve the projectile's rigid body
			Rigidbody ProjectileRB = projectileInstance.GetComponent<Rigidbody> ();

			// launch the projectile
			ProjectileRB.AddForce (transform.position + transform.forward * projectileSpeed * Time.deltaTime);

			// play the sound
			//*SoundManager.Instance.OnFireProjectile ();*
		}

	}
	// Player Controls - Movement
	void FixedUpdate () {

		// Movement - Forward and Back
		if (Input.GetKey (KeyCode.LeftShift) & Input.GetKey ("w"))
			PlayerRb.MovePosition (transform.position - transform.up * (moveSpeedBack * 2) * Time.deltaTime);
		
		else if (Input.GetKey ("w"))
			PlayerRb.MovePosition (transform.position - transform.up * moveSpeedBack * Time.deltaTime);
		
		if (Input.GetKey ("s"))
			PlayerRb.MovePosition (transform.position + transform.up * moveSpeedForward * Time.deltaTime);

		else
			return;

	}
}
