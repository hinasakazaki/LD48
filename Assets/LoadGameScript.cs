using UnityEngine;
using System.Collections;

public class LoadGameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D coll) {
		Application.LoadLevel ("city");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
