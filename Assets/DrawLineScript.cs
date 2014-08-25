using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawLineScript : MonoBehaviour {
	public PlayerScript hero;
	private LineRenderer line;
	private bool stitching;
	private bool wasStitching;
	private List<Vector3> pointsList;
	private Vector3 heroPos;

	struct myLine {
		public Vector3 StartPoint;
		public Vector3 EndPoint;
	};

	void Awake() {
		line = gameObject.AddComponent<LineRenderer> ();
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.SetVertexCount (0);
		line.SetWidth (0.3f, 0.3f);
		line.SetColors (Color.white, Color.white);
		line.useWorldSpace = true;
		stitching = false;
		pointsList = new List<Vector3>();
	}
	
	// Update is called once per frame
	void Update () {
		if (hero.isStitching()) {
			stitching = true;
		}
		else if (hero.isStitching() == false){
			pointsList = new List<Vector3>();
			stitching = false;
		}
		//Drawing line
		if (stitching) {
			heroPos = hero.transform.position;
			heroPos.z = 0;
			if (!pointsList.Contains(heroPos)) {
				pointsList.Add(heroPos);
				line.SetVertexCount (pointsList.Count);
				line.SetPosition (pointsList.Count -1, (Vector3)pointsList[pointsList.Count -1]);
			}
		}
	}
}
