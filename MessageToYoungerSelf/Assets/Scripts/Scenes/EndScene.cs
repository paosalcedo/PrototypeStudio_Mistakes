using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScene : Scene<TransitionData>
{

    [SerializeField] private int _drinks;
    [SerializeField] private Text headlineText;
    [SerializeField] private Text subheadText;

    private readonly string[] _messages =
    {
        "Drinking is fun, but you have your limits, I promise.",
        "So what if they drink more than you?",
        "It's tempting to let go, but trust me, you need to stay in control.",
        "I know you feel unloved, but having another drink won't fix that.",
        "You think you're in control, but you're not.",
        "Please, 'wag mong uulitin ang mga kasalanan ko."
    };

//    private Dictionary<int, Vector2Int> _resolutions = new Dictionary<int, Vector2Int>()
//    {
//        {0, new Vector2Int(1024, 1408)},
//        {1, new Vector2Int(960, 1320)},
//        {2, new Vector2Int(640, 880)},
//        {3, new Vector2Int(512, 704)},
//        {4, new Vector2Int(256, 352)},
//        {5, new Vector2Int(256, 352)},
//        {6, new Vector2Int(256, 352)},
//    };

    protected override void OnEnter(TransitionData data)
    {
        _drinks = data._drinks;
        headlineText.text = _messages[data._drinks];
        Debug.Log(_drinks);
        Screen.SetResolution(
            ScreenResolutions.Resolutions[_drinks].x, 
            ScreenResolutions.Resolutions[_drinks].y, true
        );
        
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
