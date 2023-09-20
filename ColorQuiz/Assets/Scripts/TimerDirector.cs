using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSetting.remaining_time <= 0f)
        {
            SceneManager.LoadScene("ResultScene");
            return;
        }

        GameSetting.remaining_time -= Time.deltaTime;

        int minute = (int) GameSetting.remaining_time / 60;
        int seconds = (int) GameSetting.remaining_time % 60;

        this.GetComponent<TextMeshProUGUI>().text = minute.ToString("00") + ":" + seconds.ToString("00");
    }

}
