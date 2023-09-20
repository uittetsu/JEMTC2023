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
        this.GetComponent<TextMeshProUGUI>().text = "得点 :" + GameSetting.score.ToString()
                                                    + "\n正解数 :" + GameSetting.collect_num.ToString()
                                                    + "\n不正解数 :" + GameSetting.incollect_num.ToString();
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
