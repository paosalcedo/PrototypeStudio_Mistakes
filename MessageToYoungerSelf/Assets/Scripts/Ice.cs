using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ice : MonoBehaviour
{
	private Rigidbody _rb;

	[SerializeField]private float _antigrav = 0.25f;
	// Use this for initialization
	void Start ()
	{
		_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_rb.velocity = Vector3.up * _antigrav;
//		_rb.AddForce()
	}
}

