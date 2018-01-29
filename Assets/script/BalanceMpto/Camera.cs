using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    internal static Vector3 main;
    public Transform target;
	Vector3 camer;

	// Use this for initialization
	void Start () {
		camer = target.position;
		camer.z -= 10;
	}
	
	// Update is called once per frame
	void Update () {
		camer = target.position;
		camer.z -= 10;
		transform.position = camer;
	}
}
