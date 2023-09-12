using System.Collections;
using System.Collections.Generic;
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

}
