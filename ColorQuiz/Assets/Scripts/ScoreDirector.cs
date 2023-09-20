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
        this.GetComponent<TextMeshProUGUI>().text = "ìæì_ :" + GameSetting.score.ToString()
                                                    +"\nê≥âêî :" + GameSetting.collect_num.ToString() 
                                                    +"\nïsê≥âêî :" + GameSetting.incollect_num.ToString();
    }
}
