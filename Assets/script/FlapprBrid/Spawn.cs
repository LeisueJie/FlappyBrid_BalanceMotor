using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject colum;
    private float startSpawn = 0f;
    private float nextSpawn = 2f;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > startSpawn && GameOver.isActive)
        {
            startSpawn = Time.time + nextSpawn;
            Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-2f, 3f), 0);
            Instantiate(colum, spawnPosition, transform.rotation);
        }
        
	}
}
