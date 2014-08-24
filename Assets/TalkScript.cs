using UnityEngine;
using System.Collections;

public class TalkScript : MonoBehaviour {
	public GameObject talk;
	bool collided = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		talk.SetActive (collided);

	}

	void OnCollisionEnter2D(Collision2D coll) {
		collided = true;
		Invoke ("Clear", 3f);
	}

	void Clear() {
		collided = false;
		talk.SetActive (false);
	}
}
