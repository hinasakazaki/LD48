using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class EnemyScript : MonoBehaviour {
	public AudioClip impact;
	void OnCollisionEnter2D(Collision2D coll) {
		audio.PlayOneShot(impact, 1.0f);
		Invoke ("Dead", 0.1f);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (dead) gameObject.SetActive (false);
	
	}
	void Dead(){
		gameObject.SetActive (false);
	}
}
