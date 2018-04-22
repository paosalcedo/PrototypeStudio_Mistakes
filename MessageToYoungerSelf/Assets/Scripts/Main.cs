﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Main : MonoBehaviour {
	void Awake(){
		Services.Prefabs = Resources.Load<PrefabDB>("Prefabs/PrefabDB");
		Services.Scenes = new SceneManager<TransitionData>(gameObject, Services.Prefabs.Levels);
		Services.Scenes.PushScene<TitleScene>();
 	}
	void Start () {
//		Screen.SetResolution(ScreenResolutions.Resolutions[0].x, ScreenResolutions.Resolutions[0].y, true);	
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
