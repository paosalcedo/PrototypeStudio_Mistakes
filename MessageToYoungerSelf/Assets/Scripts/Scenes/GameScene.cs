using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Rewired;

public class GameScene : Scene<TransitionData> {

	[SerializeField]private int _drinks;
	[SerializeField]GameObject[] _levels;
	private GameObject _player;
	[SerializeField] private Transform _spawnTransform;

	
	//set everything but the current level to inactive
	protected override void OnEnter(TransitionData data)
	{
		foreach (var level in _levels){
			level.SetActive(false);
		}
		Assert.IsNotNull(data, "Transition data is null");
		_levels[data._drinks].SetActive(true);
		_drinks = data._drinks;
		AddPlayerToScene();
	}

	void Update()
	{
		CheckPlayerY(_player, _drinks);
	}

	void AddPlayerToScene()
	{
		_player = Instantiate(Services.Prefabs.Player);
		_player.transform.position = Vector3.zero;
		_player.transform.position = _spawnTransform.position;
	}

	private void CheckPlayerY(GameObject player, int drinks)
	{
		switch (drinks)
		{
			case 0:
				if (player.transform.position.y >= 0)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 1:
				if (player.transform.position.y >= 0.45f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 2:
				if (player.transform.position.y >= 0.90f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 3: 
				if (player.transform.position.y >= 1.35f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 4:
				if (player.transform.position.y >= 1.80f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 5:
				if (player.transform.position.y >= 2.25f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
			case 6:
				if (player.transform.position.y >= 2.70f)
				{
					Destroy(player);
					Services.Scenes.PushScene<EndScene>(new TransitionData(_drinks));
				}
				break;
		}
	}

}
