using UnityEngine;
using System.Collections;

public class SwagTalkScript : MonoBehaviour {
	public GameObject swag;
	Animator swagAnim;

	// Use this for initialization
	void Start () {
		swagAnim = swag.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		swagAnim.SetBool("swagtalk", true);
		Invoke ("End", 15f);
	}

	void End(){
		swag.SetActive (false);
	}
}
