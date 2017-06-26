using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nakami : MonoBehaviour {
	public GameObject honntai;
	// Use this for initialization
	void Start () {
		honntai = GameObject.Find ("pettobotoru");
	}
	
	// Update is called once per frame
	void Update () {
		if (!GetComponent<Renderer>().isVisible) {
			Destroy(this.gameObject);
			honntai.GetComponent<pettobotoru> ().kazu-=1;
		}
	}
}
