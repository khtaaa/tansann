using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pettobotoru : MonoBehaviour {
	public GameObject start_button;
	public GameObject nakami;
	public int power;
	public Vector3 pos;
	public Vector3 mpos;
	public int kazu;
	// Use this for initialization
	void Start () {
		start_button.SetActive(true);
		kazu = 0;

		power = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (kazu < 1000) {
			Instantiate (nakami,transform.position, Quaternion.identity);
			kazu++;
		}

		if (start_button.GetComponent<start_button>().ok==true) {
			start_button.SetActive(false);
			mpos = Input.mousePosition;
			mpos.z = 10f;
			pos = Camera.main.ScreenToWorldPoint (mpos);
			if (transform.position != pos) {
				if (transform.position.x > pos.x) {
					transform.Translate (-0.1f, 0f, 0f);
				} else {
					transform.Translate (0.1f, 0f, 0f);
				}

				if (transform.position.y > pos.y) {
					transform.Translate (0f, -0.1f, 0f);
				} else {
					transform.Translate (0f, 0.1f, 0f);
				}
				power++;
			}
		}
	}
}
