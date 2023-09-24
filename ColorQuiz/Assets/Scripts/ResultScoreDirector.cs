using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScoreDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TextMeshProUGUI>().text = "���_:" + GameSetting.score.ToString()
                                                    + "\n����:" + GameSetting.collect_num.ToString()
                                                    + "\n�s����:" + GameSetting.incollect_num.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void B1Click()
    {
        SceneManager.LoadScene("StartScene");
    }
}
