﻿using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	public string NextScene = "SceneJaques";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            SceneManager.LoadScene(NextScene);
        }
	}
}
