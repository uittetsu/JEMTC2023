using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    GameObject GameSetting;

    Color ans_color = new Color();

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

        this.GameSetting = GameObject.Find("GameSetting");

        string[] text_set = this.GameSetting.GetComponent<GameSetting>().text_set;
        Color[] color_set = this.GameSetting.GetComponent<GameSetting>().color_set;

        this.QuestionDirector = GameObject.Find("QuestionDirector");

        this.ans_color = QuestionDirector.GetComponent<QuestionDirector>().ans_color;

        this.b1_text.GetComponent<TextMeshProUGUI>().text = "red";
        this.b2_text.GetComponent<TextMeshProUGUI>().text = "blue";
        this.b3_text.GetComponent<TextMeshProUGUI>().text = "green";
        this.b4_text.GetComponent<TextMeshProUGUI>().text = "yellow";

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void B1Click()
    {
        if (this.ans_color == Color.red)
        {
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            SceneManager.LoadScene("FailedScene");
        }
    }

    public void B2Click()
    {
        if (this.ans_color == Color.blue)
        {
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            SceneManager.LoadScene("FailedScene");
        }
    }

    public void B3Click()
    {
        if (this.ans_color == Color.green)
        {
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            SceneManager.LoadScene("FailedScene");
        }
    }

    public void B4Click()
    {
        if (this.ans_color == Color.yellow)
        {
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            SceneManager.LoadScene("FailedScene");
        }
    }
}
