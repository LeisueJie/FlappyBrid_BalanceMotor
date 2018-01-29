using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tube : MonoBehaviour {

    public float tubeSpeed = 2f;

	// Use this for initialization
	void Start () {
        if (GameOver.isActive)
        {
            Destroy(gameObject, 20);
        }    
    }
	
	// Update is called once per frame
	void Update () {
        if (GameOver.isActive)
        {
            transform.Translate(Vector3.left * tubeSpeed * Time.deltaTime);
        }
	}
}
