using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	private bool stitching = false;

	// Use this for initialization
	void Start () {
	
	}
	

	public bool isStitching() {
		return stitching;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("stitch")) {
						stitching = true;
				} else if (Input.GetButtonUp ("stitch")) {
						stitching = false;
				}

	}
}
