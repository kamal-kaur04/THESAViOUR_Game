﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public void LoadScene(string name){
		Application.LoadLevel(name);
	}
	public void QuitGame(){
		Application.Quit();
	}

}
