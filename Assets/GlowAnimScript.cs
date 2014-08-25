using UnityEngine;
using System.Collections;

public class GlowAnimScript : MonoBehaviour {

	float targetScale = 3.0f;
	float shrinkSpeed = 0.5f;
	Vector3 original;
	bool shrinking = false;
	
	void Start() {
		original = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (!shrinking) {
			transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime*shrinkSpeed);
		}
		if (shrinking) {
			transform.localScale = Vector3.Lerp(transform.localScale, original, Time.deltaTime*shrinkSpeed);
		}
		
		if (transform.localScale.x >= 2.9f) {
			shrinking = true;
		}
		
		if (transform.localScale.x <= 0.9f) {
			shrinking = false;
		}
	}
}
