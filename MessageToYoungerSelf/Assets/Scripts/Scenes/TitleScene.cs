using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : Scene<TransitionData>
{

	[SerializeField] private int _startLevel = 0;

	protected override void OnEnter(TransitionData data)
	{
		Screen.SetResolution(
			ScreenResolutions.Resolutions[_startLevel].x,
			ScreenResolutions.Resolutions[_startLevel].y,
			true
		);
	}

	private void Update(){
		if(Input.GetKeyDown(KeyCode.Return)){
			Services.Scenes.PushScene<GameScene>(new TransitionData(_startLevel));
		}
	}


}
