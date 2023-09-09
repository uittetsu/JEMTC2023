using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartButtonDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClick()
    {
        GameSetting.collect_num = 0;
        GameSetting.incollect_num = 0;
        GameSetting.remaining_time = 30.0f;
        SceneManager.LoadScene("GameScene");
    }
}
