using UnityEngine;
using System.Collections;

public class ParallexScript : MonoBehaviour {

	public Transform[] backgrounds;
	private float[] parallexScaling;
	public float smoothing = 1f;

	private Transform cam; //main camera transform
	private Vector3 previousCamPos; //position of camera in previous frame

	void Awake(){
		//set up references
		cam = Camera.main.transform;

	}

	// Use this for initialization
	void Start () {
		previousCamPos = cam.position;
		parallexScaling = new float[backgrounds.Length];

		for (int i = 0; i < backgrounds.Length; i++) {
			parallexScaling[i] = backgrounds[i].position.z*-1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < backgrounds.Length; i++) {
			float parallex = (previousCamPos.x - cam.position.x)*parallexScaling[i];
			//set target x position which is current position + Parallex 
			float backgroundTargetPosX = backgrounds[i].position.x + parallex;

			Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);
			//fade between current position and target position using lerp
			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing*Time.deltaTime);
		}
		previousCamPos = cam.position;
	}
}