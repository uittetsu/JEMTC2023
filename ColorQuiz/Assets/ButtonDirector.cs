using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class ButtonDirector : MonoBehaviour
{
    GameObject b1;
    GameObject b2;
    GameObject b3;
    GameObject b4;
    GameObject b1_text;
    GameObject b2_text;
    GameObject b3_text;
    GameObject b4_text;
    GameObject QuestionDirector;

    Color ans_color = new Color();
    int[] use_idx;

    // Start is called before the first frame update
    void Start()
    {
        this.b1 = GameObject.Find("b1");
        this.b2 = GameObject.Find("b2");
        this.b3 = GameObject.Find("b3");
        this.b4 = GameObject.Find("b4");

        this.b1_text = this.b1.transform.GetChild(0).gameObject;
        this.b2_text = this.b2.transform.GetChild(0).gameObject;
        this.b3_text = this.b3.transform.GetChild(0).gameObject;
        this.b4_text = this.b4.transform.GetChild(0).gameObject;

        this.QuestionDirector = GameObject.Find("QuestionDirector");

        int ans_idx = QuestionDirector.GetComponent<QuestionDirector>().ans_idx;
        this.ans_color = GameSetting.color_set[ans_idx];

        this.use_idx = Enumerable.Repeat<int>(GameSetting.text_set.Length, GameSetting.text_set.Length).ToArray();
        this.use_idx[0] = ans_idx;
        int i = 1;
        while (true)
        {
            int num = Random.Range(0, GameSetting.text_set.Length);
            if (this.use_idx.Contains(num))
            {
                continue;
            }
            else
            {
                this.use_idx[i] = num;
                i++;
                if (i == GameSetting.text_set.Length)
                {
                    break;
                }
            }
        }
        this.use_idx.Shuffle();

        this.b1_text.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[this.use_idx[0]];
        this.b2_text.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[this.use_idx[1]];
        this.b3_text.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[this.use_idx[2]];
        this.b4_text.GetComponent<TextMeshProUGUI>().text = GameSetting.text_set[this.use_idx[3]];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void B1Click()
    {
        if (this.ans_color == GameSetting.color_set[this.use_idx[0]])
        {
            //SceneManager.LoadScene("ClearScene");
            GameSetting.collect_num++;
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            GameSetting.incollect_num++;
        }

        SceneManager.LoadScene("GameScene");
    }

    public void B2Click()
    {
        if (this.ans_color == GameSetting.color_set[this.use_idx[1]])
        {
            //SceneManager.LoadScene("ClearScene");
            GameSetting.collect_num++;
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            GameSetting.incollect_num++;
        }

        SceneManager.LoadScene("GameScene");
    }

    public void B3Click()
    {
        if (this.ans_color == GameSetting.color_set[this.use_idx[2]])
        {
            //SceneManager.LoadScene("ClearScene");
            GameSetting.collect_num++;
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            GameSetting.incollect_num++;
        }

        SceneManager.LoadScene("GameScene");
    }

    public void B4Click()
    {
        if (this.ans_color == GameSetting.color_set[this.use_idx[3]])
        {
            //SceneManager.LoadScene("ClearScene");
            GameSetting.collect_num++;
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            GameSetting.incollect_num++;
        }

        SceneManager.LoadScene("GameScene");
    }
}
