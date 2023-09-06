using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    public string[] text_set = new string[4] { "red", "blue", "green", "yellow" };
    public Color[] color_set = new Color[4] { Color.red, Color.blue, Color.green, Color.yellow };

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
