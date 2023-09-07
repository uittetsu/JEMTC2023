using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerDirector : MonoBehaviour
{
    public static float remaining_time = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (remaining_time <= 0f)
        {
            SceneManager.LoadScene("ResultScene");
            return;
        }

        remaining_time -= Time.deltaTime;

        int minute = (int) remaining_time / 60;
        int seconds = (int) remaining_time % 60;

        this.GetComponent<TextMeshProUGUI>().text = minute.ToString("00") + ":" + seconds.ToString("00");
    }
}
