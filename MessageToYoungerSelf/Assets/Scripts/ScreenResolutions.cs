using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolutions
{
    public static Dictionary<int, Vector2Int> Resolutions = new Dictionary<int, Vector2Int>()
    {
//        {0, new Vector2Int(640, 880)},
        {0, new Vector2Int(512, 704)},
        {1, new Vector2Int(384, 528)},
        {2, new Vector2Int(256, 352)},
        {3, new Vector2Int(192, 264)},
        {4, new Vector2Int(128, 176)},
        {5, new Vector2Int(96, 132)}
    };

}
