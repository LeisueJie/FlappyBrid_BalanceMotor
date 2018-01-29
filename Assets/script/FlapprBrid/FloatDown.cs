using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatDown : MonoBehaviour {

    public GameObject brid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameOver.isActive = false;     
        }
    }
}
