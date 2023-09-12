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
        this.GetComponent<TextMeshProUGUI>().text = "���� :" + GameSetting.collect_num.ToString()
                                                    + "\n�s���� :" + GameSetting.incollect_num.ToString()
                                                    + "\n��ʂ��N���b�N���ăX�^�[�g��ʂɖ߂�";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
