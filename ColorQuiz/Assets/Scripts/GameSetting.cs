using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    // test_set と color_set は一致させること
    public static string[] text_set = new string[6] { "あか", "あお", "みどり", "きいろ", "はいいろ", "くろ" };
    public static Color[] color_set = new Color[6] { Color.red, Color.blue, Color.green, Color.yellow, Color.gray, Color.black};

    public static float remaining_time = 30.0f;
    public static int collect_num = 0;
    public static int incollect_num = 0;

    // ボタンの数を設定 test_set以下でなければならない
    public static int button_num = 4;

    public static int score = 0;
    public static int continueous_collect_num = 0;
    public static float pre_ans_time = remaining_time;

    public static int level = 0;

    public static void ResetVal()
    {
        remaining_time = 30.0f;
        collect_num = 0;
        incollect_num = 0;
        score = 0;
        continueous_collect_num = 0;
        pre_ans_time = remaining_time;
        level = 0;
    }
}
