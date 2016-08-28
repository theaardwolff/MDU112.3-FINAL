using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float moveSpeedBack = 20.0f;
	public float moveSpeedForward = 10.0f;

	public float rotateSpeedX = 50.0f;
	public float rotateSpeedY = 50.0f;

	public float cameraSpeedX = 2.0f;
	public float cameraSpeedY = 2.0f;

	public Rigidbody rb;
	public Vector3 teleportPoint;

	public GameObject projectile;

	public GameObject[] muzzles;

	public float projectileOffset = 2f;
	public float projectileSpeed = 1000f;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

	}

	//Shoot Projectiles
	void Shoot(){
		for (int ind = 0; ind < muzzles.Length; ++ind) {
			Instantiate (projectile, muzzles [ind].transform.position, muzzles [ind].transform.rotation);
		}
	
	}
	void Update () {
		rotateSpeedX += cameraSpeedX * Input.GetAxis ("Mouse X");
		rotateSpeedY -= cameraSpeedY * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3 (rotateSpeedY, rotateSpeedX, 0.0f);

		if (Input.GetKeyDown (KeyCode.Space)) {
			// Create the projectile.
			GameObject projectileInstance = GameObject.Instantiate (projectile);

			// position the projectile slightly below the player.
			projectileInstance.transform.position = transform.position - transform.up * projectileOffset;

			// retrieve the projectile's rigid body
			Rigidbody projectileRB = projectileInstance.GetComponent<Rigidbody> ();

			// launch the projectile
			projectileRB.AddForce (transform.forward * projectileSpeed);

			// play the sound
			//*SoundManager.Instance.OnFireProjectile ();*
		}

	}
	// Player Controls - Movement
	void FixedUpdate () {

		// Movement - Forward and Back

		if (Input.GetKey ("s"))
			rb.MovePosition (transform.position + transform.up * moveSpeedForward * Time.deltaTime);

		else if (Input.GetKey ("w"))
			rb.MovePosition (transform.position - transform.up * moveSpeedBack * Time.deltaTime);

		else
			return;

	}
}
