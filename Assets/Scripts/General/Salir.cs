﻿using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {

	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
