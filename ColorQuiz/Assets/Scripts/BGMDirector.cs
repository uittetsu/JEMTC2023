using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BGMDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSetting.remaining_time > 10f)
        {
            this.GetComponent<AudioSource>().pitch = 0.5f;
        }
        else if (GameSetting.remaining_time <= 10f &&  GameSetting.remaining_time > 5f)
        {
            this.GetComponent<AudioSource>().pitch = 1f;
        }
        else if (GameSetting.remaining_time <= 5f && GameSetting.remaining_time > 0f)
        {
            this.GetComponent<AudioSource>().pitch = 2f;
        }
        else
        {
            this.GetComponent<AudioSource>().Stop();
        }
    }
}
