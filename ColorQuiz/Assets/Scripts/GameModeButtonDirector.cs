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
        GameSetting.ResetVal();
        GameSetting.level = 0;

        SceneManager.LoadScene("CountDownScene");
    }

    public void HardButtonClick()
    {
        GameSetting.ResetVal();
        GameSetting.level = 1;

        SceneManager.LoadScene("CountDownScene");
    }
}
