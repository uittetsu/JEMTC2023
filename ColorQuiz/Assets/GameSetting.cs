using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    // test_set �� color_set �͊e�v�f����v����悤�ɒ�`����
    public static string[] text_set = new string[4] { "red", "blue", "green", "yellow" };
    public static Color[] color_set = new Color[4] { Color.red, Color.blue, Color.green, Color.yellow };

    public static float remaining_time = 30.0f;
    public static int collect_num = 0;
    public static int incollect_num = 0;

}
