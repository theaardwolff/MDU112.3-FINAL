﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UILoadLevelButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void LoadLevel(string GameLevel)
	{
		SceneManager.LoadScene(GameLevel);
	}
}