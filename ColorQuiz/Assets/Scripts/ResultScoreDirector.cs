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
        this.GetComponent<TextMeshProUGUI>().text = "ìæì_:" + GameSetting.score.ToString()
                                                    + "\nê≥âêî:" + GameSetting.collect_num.ToString()
                                                    + "\nïsê≥âêî:" + GameSetting.incollect_num.ToString();
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
