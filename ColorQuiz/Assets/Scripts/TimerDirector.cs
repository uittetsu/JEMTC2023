using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerDirector : MonoBehaviour
{
    TextMeshProUGUI finish_TMP;
    TextMeshProUGUI timer_TMP;

    AudioSource audioSource;
    AudioClip finish_sound;

    // Start is called before the first frame update
    void Start()
    {
        GameObject finish = GameObject.Find("finish");
        this.finish_TMP = finish.GetComponent<TextMeshProUGUI>();

        this.timer_TMP = this.GetComponent<TextMeshProUGUI>();

        GameObject Audio = GameObject.Find("Audio");
        this.audioSource = Audio.GetComponent<AudioSource>();
        this.finish_sound = Audio.GetComponent<AudioDirector>().finish_sound;

    }

    // Update is called once per frame
    void Update()
    {
        GameSetting.remaining_time -= Time.deltaTime;

        if (GameSetting.remaining_time <= 0f)
        {
            StartCoroutine(wait());
        }
        else
        {
            int minute = (int)GameSetting.remaining_time / 60;
            int seconds = (int)GameSetting.remaining_time % 60;

            this.timer_TMP.text = "‚Ì‚±‚è " + seconds.ToString("00") + " •b";
        }
    }

    IEnumerator wait()
    {
        this.finish_TMP.enabled = true;
        this.audioSource.PlayOneShot(this.finish_sound);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ResultScene");
    }
}
