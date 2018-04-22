using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : Scene<TransitionData>
{

	[SerializeField] private int _startLevel = 0;

	private void Update(){
		if(Input.GetKeyDown(KeyCode.Return)){
			Services.Scenes.PushScene<GameScene>(new TransitionData(_startLevel));
		}
	}


}
