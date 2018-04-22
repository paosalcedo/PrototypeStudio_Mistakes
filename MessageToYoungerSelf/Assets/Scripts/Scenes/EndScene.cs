using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : Scene<TransitionData>
{
 
    [SerializeField]private int _drinks;
    
    protected override void OnEnter(TransitionData data)
    {
        _drinks = data._drinks;
        ++_drinks;
    }
    
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            if (_drinks != 6)
            {
                Services.Scenes.PushScene<GameScene>(new TransitionData(_drinks));            
            }
            else
            {
                Services.Scenes.PushScene<TitleScene>();
            }
        }
    }
}
