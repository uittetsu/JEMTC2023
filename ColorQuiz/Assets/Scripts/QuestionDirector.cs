using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionDirector : MonoBehaviour
{
    GameObject question;

    GameObject Audio;
    AudioSource audioSource;

    public int ans_idx;

    // Start is called before the first frame update
    void Start()
    {
        this.Audio = GameObject.Find("Audio");
        this.audioSource = this.Audio.GetComponent<AudioSource>();

        this.question = GameObject.Find("question");

        int text_idx = Random.Range(0, GameSetting.text_set.Length);

        this.question.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[text_idx];

        // 色とテキストが同じにならないようにする
        int color_idx = Random.Range(0, GameSetting.color_set.Length - 1);
        if (color_idx >= text_idx)
        {
            color_idx++;
        }

        this.question.GetComponent<TextMeshProUGUI>().color = GameSetting.color_set[color_idx];

        this.ans_idx = color_idx;

        this.audioSource.PlayOneShot(this.Audio.GetComponent<AudioDirector>().question_sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
