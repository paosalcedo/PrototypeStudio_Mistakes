using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class MyPlayer : MonoBehaviour
{

	[SerializeField] private float _moveSpeed;
	
	[SerializeField]private int _playerId = 0;
	Player _rewiredPlayer;
	private Vector3 _moveVec3;

	private Rigidbody _rb;
	// Use this for initialization
	void Start () {
		_rewiredPlayer = ReInput.players.GetPlayer(_playerId);
		_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		GetInput();
		ProcessInput();

		if (_moveSpeed >= 0)
		{
			_moveSpeed -= 0.05f * Time.deltaTime;		
		}
	}
	
	void GetInput()
	{
		_moveVec3.y = _rewiredPlayer.GetAxis("Swim Vertical");
		_moveVec3.x = _rewiredPlayer.GetAxis("Swim Horizontal");
	}

	void ProcessInput()
	{
 		_rb.velocity = _moveVec3 * _moveSpeed;
 	}
}
