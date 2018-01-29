using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoCtrl : MonoBehaviour {

	public WheelJoint2D right;
	public WheelJoint2D left;

	[SerializeField]float speed = 0f;
	[SerializeField]float rotato = 0f;

	Rigidbody2D rg;
	JointMotor2D motor;

	// Use this for initialization
	void Start () {
		motor.maxMotorTorque = 10000;
		rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		motor.motorSpeed = -speed * Input.GetAxis("Horizontal");
		right.motor = motor;
		left.motor = motor;
		rg.AddTorque (rotato * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
