using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionDirector : MonoBehaviour
{
    GameObject question;

    public int ans_idx;

    // Start is called before the first frame update
    void Start()
    {
        this.question = GameObject.Find("question");

        int text_idx = Random.Range(0, GameSetting.text_set.Length);
        this.question.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[text_idx];

        int color_idx = Random.Range(0, GameSetting.color_set.Length);
        this.question.GetComponent<TextMeshProUGUI>().color = GameSetting.color_set[color_idx];

        this.ans_idx = color_idx;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
