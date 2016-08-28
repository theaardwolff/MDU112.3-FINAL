using UnityEngine;
using System.Collections;

public class MinimapController : MonoBehaviour {
	
	protected GameObject player;
	public Vector3 cameraOffset = new Vector3(0, 50, 0);

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + cameraOffset;
	}
}