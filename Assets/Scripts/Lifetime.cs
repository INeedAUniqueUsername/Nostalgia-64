﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {
    public int lifetime;
	// Update is called once per frame
	void Update () {
        if (lifetime == 0) {
            Destroy(gameObject);
        } else {
            lifetime--;
        }
	}
}
