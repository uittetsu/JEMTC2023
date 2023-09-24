using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    TextMeshProUGUI b1_TMP;
    TextMeshProUGUI b2_TMP;
    TextMeshProUGUI b3_TMP;
    TextMeshProUGUI b4_TMP;

    TextMeshProUGUI question_TMP;

    AudioSource audioSource;
    AudioClip question_sound;
    AudioClip collect_sound;
    AudioClip incollect_sound;

    int ans_idx;
    Color ans_color = new Color();
    int[] use_idx = new int[GameSetting.button_num];

    public Sprite maru;
    public Sprite batsu;

    Image b1_mb_img;
    Image b2_mb_img;
    Image b3_mb_img;
    Image b4_mb_img;

    // Start is called before the first frame update
    void Start()
    {
        GameObject b1 = GameObject.Find("b1");
        GameObject b2 = GameObject.Find("b2");
        GameObject b3 = GameObject.Find("b3");
        GameObject b4 = GameObject.Find("b4");

        GameObject b1_text = b1.transform.GetChild(0).gameObject;
        GameObject b2_text = b2.transform.GetChild(0).gameObject;
        GameObject b3_text = b3.transform.GetChild(0).gameObject;
        GameObject b4_text = b4.transform.GetChild(0).gameObject;

        this.b1_TMP = b1_text.GetComponent<TextMeshProUGUI>();
        this.b2_TMP = b2_text.GetComponent<TextMeshProUGUI>();
        this.b3_TMP = b3_text.GetComponent<TextMeshProUGUI>();
        this.b4_TMP = b4_text.GetComponent<TextMeshProUGUI>();

        GameObject question = GameObject.Find("question");
        this.question_TMP = question.GetComponent<TextMeshProUGUI>();

        GameObject Audio = GameObject.Find("Audio");
        this.audioSource = Audio.GetComponent<AudioSource>();
        this.question_sound = Audio.GetComponent<AudioDirector>().question_sound;
        this.collect_sound = Audio.GetComponent<AudioDirector>().collect_sound;
        this.incollect_sound = Audio.GetComponent<AudioDirector>().incollect_sound;

        GameObject b1_mb = GameObject.Find("b1_mb");
        GameObject b2_mb = GameObject.Find("b2_mb");
        GameObject b3_mb = GameObject.Find("b3_mb");
        GameObject b4_mb = GameObject.Find("b4_mb");

        //this.b1_mb_img = b1_mb.GetComponent<Image>();
        //this.b2_mb_img = b2_mb.GetComponent<Image>();
        //this.b3_mb_img = b3_mb.GetComponent<Image>();
        //this.b4_mb_img = b4_mb.GetComponent<Image>();

        MakeGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeButton()
    {
        this.ans_color = GameSetting.color_set[ans_idx];

        this.use_idx = Enumerable.Repeat<int>(GameSetting.text_set.Length, GameSetting.button_num).ToArray();
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
                if (i == GameSetting.button_num)
                {
                    break;
                }
            }
        }
        //print(string.Join(", ", use_idx.Select(x => x.ToString())));
        this.use_idx.Shuffle();

        this.b1_TMP.text = GameSetting.text_set[this.use_idx[0]];
        this.b2_TMP.text = GameSetting.text_set[this.use_idx[1]];
        this.b3_TMP.text = GameSetting.text_set[this.use_idx[2]];
        this.b4_TMP.text = GameSetting.text_set[this.use_idx[3]];

        if (GameSetting.level == 1)
        {
            this.b1_TMP.color = GameSetting.color_set[Random.Range(0, GameSetting.color_set.Length)];
            this.b2_TMP.color = GameSetting.color_set[Random.Range(0, GameSetting.color_set.Length)];
            this.b3_TMP.color = GameSetting.color_set[Random.Range(0, GameSetting.color_set.Length)];
            this.b4_TMP.color = GameSetting.color_set[Random.Range(0, GameSetting.color_set.Length)];
        }
    }

    void MakeQuestion()
    {
        int text_idx = Random.Range(0, GameSetting.text_set.Length);

        this.question_TMP.text = GameSetting.text_set[text_idx];

        // 色とテキストが同じにならないようにする
        int color_idx = Random.Range(0, GameSetting.color_set.Length - 1);
        if (color_idx >= text_idx)
        {
            color_idx++;
        }

        this.question_TMP.color = GameSetting.color_set[color_idx];

        this.ans_idx = color_idx;

        this.audioSource.PlayOneShot(this.question_sound);
    }

    void MakeGame()
    {
        //this.b1_mb_img.enabled = false;
        //this.b2_mb_img.enabled = false;
        //this.b3_mb_img.enabled = false;
        //this.b4_mb_img.enabled = false;

        MakeQuestion();
        MakeButton();
    }
    

    public void B1Click()
    {
        //MakeMB();

        if (this.ans_color == GameSetting.color_set[this.use_idx[0]])
        {
            //SceneManager.LoadScene("ClearScene");
            this.audioSource.PlayOneShot(this.collect_sound);
            GameSetting.collect_num++;
            AddScore();
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            this.audioSource.PlayOneShot(this.incollect_sound);
            GameSetting.incollect_num++;
            MinusScore();
        }

        MakeGame();
    }

    public void B2Click()
    {
        //MakeMB();
        if (this.ans_color == GameSetting.color_set[this.use_idx[1]])
        {
            //SceneManager.LoadScene("ClearScene");
            this.audioSource.PlayOneShot(this.collect_sound);
            GameSetting.collect_num++;
            AddScore();
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            this.audioSource.PlayOneShot(this.incollect_sound);
            GameSetting.incollect_num++;
            MinusScore();
        }

        MakeGame();
    }

    public void B3Click()
    {
        //MakeMB();
        if (this.ans_color == GameSetting.color_set[this.use_idx[2]])
        {
            //SceneManager.LoadScene("ClearScene");
            this.audioSource.PlayOneShot(this.collect_sound);
            GameSetting.collect_num++;
            AddScore();
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            this.audioSource.PlayOneShot(this.incollect_sound);
            GameSetting.incollect_num++;
            MinusScore();
        }

        MakeGame();
    }

    public void B4Click()
    {
        //MakeMB();
        if (this.ans_color == GameSetting.color_set[this.use_idx[3]])
        {
            //SceneManager.LoadScene("ClearScene");
            this.audioSource.PlayOneShot(this.collect_sound);
            GameSetting.collect_num++;
            AddScore();
        }
        else
        {
            //SceneManager.LoadScene("FailedScene");
            this.audioSource.PlayOneShot(this.incollect_sound);
            GameSetting.incollect_num++;
            MinusScore();
        }

        MakeGame();
    }

    void MakeMB()
    {
        if (this.ans_color == GameSetting.color_set[this.use_idx[0]])
        {
            this.b1_mb_img.sprite = this.maru;
            this.b2_mb_img.sprite = this.batsu;
            this.b3_mb_img.sprite = this.batsu;
            this.b4_mb_img.sprite = this.batsu;
        }
        else if (this.ans_color == GameSetting.color_set[this.use_idx[1]])
        {
            this.b1_mb_img.sprite = this.batsu;
            this.b2_mb_img.sprite = this.maru;
            this.b3_mb_img.sprite = this.batsu;
            this.b4_mb_img.sprite = this.batsu;
        }
        else if (this.ans_color == GameSetting.color_set[this.use_idx[2]])
        {
            this.b1_mb_img.sprite = this.batsu;
            this.b2_mb_img.sprite = this.batsu;
            this.b3_mb_img.sprite = this.maru;
            this.b4_mb_img.sprite = this.batsu;
        }
        else if (this.ans_color == GameSetting.color_set[this.use_idx[1]])
        {
            this.b1_mb_img.sprite = this.batsu;
            this.b2_mb_img.sprite = this.batsu;
            this.b3_mb_img.sprite = this.batsu;
            this.b4_mb_img.sprite = this.maru;
        }

        this.b1_mb_img.enabled = true;
        this.b2_mb_img.enabled = true;
        this.b3_mb_img.enabled = true;
        this.b4_mb_img.enabled = true;
    }

    void AddScore()
    {
        int add_score = 0;

        if (GameSetting.pre_ans_time - GameSetting.remaining_time < 1f)
        {
            add_score = (int)((1000 + 100 * GameSetting.continueous_collect_num) * 1.5);
        }
        else if (GameSetting.pre_ans_time - GameSetting.remaining_time < 2f)
        {
            add_score = (int)((1000 + 100 * GameSetting.continueous_collect_num) * 1.1);
        }
        else
        {
            add_score = (int)(1000 + 100 * GameSetting.continueous_collect_num);
        }

        if (GameSetting.remaining_time < 5f)
        {
            add_score = (int)(add_score * 1.2);
        }

        GameSetting.continueous_collect_num++;
        GameSetting.pre_ans_time = GameSetting.remaining_time;
        GameSetting.score += add_score;
    }

    void MinusScore()
    {
        int minus_score = 0;

        if (GameSetting.pre_ans_time - GameSetting.remaining_time < 1f)
        {
            minus_score = (int)((-500 + 100 * GameSetting.continueous_collect_num) * 1.5);
        }
        else if (GameSetting.pre_ans_time - GameSetting.remaining_time < 2f)
        {
            minus_score = (int)((-500 + 100 * GameSetting.continueous_collect_num) * 1.1);
        }
        else
        {
            minus_score = (int)(-500 + 100 * GameSetting.continueous_collect_num);
        }

        if (GameSetting.remaining_time < 5f)
        {
            minus_score = (int)(minus_score * 1.2);
        }

        GameSetting.continueous_collect_num = 0;
        GameSetting.pre_ans_time = GameSetting.remaining_time;
        GameSetting.score += minus_score;
    }
}
