﻿using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {
	
	private static MusicScript instance = null;
	public static MusicScript Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// any other methods you need
}