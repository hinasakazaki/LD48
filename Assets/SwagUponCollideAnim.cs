using UnityEngine;
using System.Collections;

public class SwagUponCollideAnim : MonoBehaviour {
	float targetScale = 15.0f;
	float growSpeed = 0.5f;
	public GameObject sparkles;
	public GameObject swag;
	public GameObject dialog;
	public GameObject badTalk;
	bool sparklesPresent = false;
	Animator talkAnim;

	// Use this for initialization
	void Start () {
		talkAnim = dialog.GetComponent<Animator> ();
	}
	void OnCollisionEnter2D(Collision2D coll) {
		sparkles.SetActive (true);
		sparklesPresent = true;
		Invoke ("Gone", 3f);
	}

	// Update is called once per frame
	void Update () {
		if (sparklesPresent) {
			sparkles.transform.localScale = Vector3.Lerp(sparkles.transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime*growSpeed);
		}
	
	}

	void Gone(){
		swag.SetActive (false);
		Invoke ("Dialog", 0.5f);
		badTalk.SetActive (true);
	}

	void Dialog(){
		talkAnim.SetBool ("swagtalk", true);
		Invoke ("StopTalk", 20f);
	}

	void StopTalk(){
		talkAnim.SetBool ("swagtalk", false);
		dialog.SetActive (false);
	}
}
