﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriterotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(0, 0,10*Time.deltaTime);
	}
}
