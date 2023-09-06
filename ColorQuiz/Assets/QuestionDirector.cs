using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionDirector : MonoBehaviour
{
    GameObject question;
    GameObject GameSetting;

# string[] text_set = new string[4] { "red", "blue", "green", "yellow" };
# Color[] color_set = new Color[4] { Color.red, Color.blue, Color.green, Color.yellow };
    public Color ans_color = new Color();

    // Start is called before the first frame update
    void Start()
    {
        this.question = GameObject.Find("question");
        this.GameSetting = GameObject.Find("GameSetting");

        string[] text_set = this.GameSetting.GetComponent<GameSetting>().text_set;
        Color[] color_set = this.GameSetting.GetComponent<GameSetting>().color_set;

        int text_idx = Random.Range(0, text_set.Length);
        this.question.GetComponent<TextMeshProUGUI>().text = text_set[text_idx];

        int color_idx = Random.Range(0, color_set.Length);
        this.question.GetComponent<TextMeshProUGUI>().color = color_set[color_idx];

        this.ans_color = color_set[color_idx];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
