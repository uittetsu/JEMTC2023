using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "得点 :" + GameSetting.score.ToString()
                                                    +"\n正解数 :" + GameSetting.collect_num.ToString() 
                                                    +"\n不正解数 :" + GameSetting.incollect_num.ToString();
    }
}
