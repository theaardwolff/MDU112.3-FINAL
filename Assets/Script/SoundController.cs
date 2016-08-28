using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	// ------------------------------------------------------------------------
	// Beginning of the code to make SoundManager a singleton

	public static SoundController Instance;

	void Awake()
	{
		Instance = this;
	}

	// End of the code for making it a singleton
	// ------------------------------------------------------------------------

	public AudioSource SFXChannel;

	public AudioClip[] ShootSounds;

	public void ProjectileShoot()
	{
		// safety check so we don't access values that don't exist
		if (ShootSounds.Length == 0)
		{
			Debug.LogError("No ShootSounds. WHYYYY?");
			return;
		}

		// pick a random sound
		AudioClip clip = ShootSounds[Random.Range(0, ShootSounds.Length)];

		// play the sound
		SFXChannel.PlayOneShot(clip);
	}
}