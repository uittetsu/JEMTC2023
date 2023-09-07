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
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "collect :" + ScoreDirector.collect_num.ToString() 
                                                    + "\nincollect :" + ScoreDirector.incollect_num.ToString()
                                                    + "\nclick to play again!!";

        if (Input.GetMouseButtonDown(0))
        {
            ScoreDirector.collect_num = 0;
            ScoreDirector.incollect_num = 0;
            TimerDirector.remaining_time = 30.0f;
            SceneManager.LoadScene("GameScene");
        }
    }
}
