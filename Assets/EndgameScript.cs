using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EndgameScript : MonoBehaviour {
	public GameObject sparkles;
	public GameObject endtalk;
	public AudioClip endSound;
	float targetScale = 15.0f;
	float growSpeed = 0.5f;
	bool sparklesPresent = false;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		sparkles.SetActive (true);
		sparklesPresent = true;
		endtalk.SetActive (true);
		audio.PlayOneShot(endSound, 1.0f);
		Invoke ("BackToMain", 6f);
	}

	// Update is called once per frame
	void Update () {
		if (sparklesPresent) {
			sparkles.transform.localScale = Vector3.Lerp(sparkles.transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime*growSpeed);
		}
	}

	void BackToMain(){
		Application.LoadLevel ("launch");
	}
}
