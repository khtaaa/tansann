using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_button : MonoBehaviour {
	public bool ok;
	// Use this for initialization
	void Start () {
		ok = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void state()
	{
		ok = true;
	}

}
