using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Load4thLevel : MonoBehaviour {
	public GameObject sparkles;
	public AudioClip tada;
	float targetScale = 15.0f;
	float growSpeed = 0.5f;
	bool sparklesPresent = false;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D coll) {
		sparkles.SetActive (true);
		sparklesPresent = true;
		Invoke ("LoadLevel", 3f);
		audio.PlayOneShot(tada, 1.0f);
	}

	
	// Update is called once per frame
	void Update () {
		if (sparklesPresent) {
			sparkles.transform.localScale = Vector3.Lerp(sparkles.transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime*growSpeed);
		}
	}

	void LoadLevel(){
		Application.LoadLevel ("ocean");
	}
}
