using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Motoren : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "backgroud"){
            SceneManager.LoadScene("GitHub");
        }
	}
}
