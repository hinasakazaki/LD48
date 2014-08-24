using UnityEngine;
using System.Collections;

public class BacktoLevel1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		Application.LoadLevel ("city");
	}
}
