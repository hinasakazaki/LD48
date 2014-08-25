using UnityEngine;
using System.Collections;

public class Load3rdLevel : MonoBehaviour {
	float targetScale = 15.0f;
	float growSpeed = 0.5f;
	public GameObject done;
	Animator doneAnim;
	public GameObject blue;
	public GameObject swagtalk;
	bool blueShine = false;
	// Use this for initialization
	void Start () {
		doneAnim = done.GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (blueShine) {
			blue.transform.localScale = Vector3.Lerp(blue.transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime*growSpeed);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		swagtalk.SetActive (false);
		blueShine = true;
		blue.SetActive (true);
		Invoke ("LoadLevel", 3f);
		doneAnim.SetBool("done", true);
	}

	void LoadLevel(){
		Application.LoadLevel ("forest");
	}

}
