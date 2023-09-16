using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeButtonDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NormalButtonClick()
    {
        GameSetting.collect_num = 0;
        GameSetting.incollect_num = 0;
        GameSetting.remaining_time = 30.0f;

        SceneManager.LoadScene("NormalGameScene");
    }

    public void HardButtonClick()
    {
        GameSetting.collect_num = 0;
        GameSetting.incollect_num = 0;
        GameSetting.remaining_time = 30.0f;

        SceneManager.LoadScene("HardGameScene");
    }
}
