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
        this.GetComponent<TextMeshProUGUI>().text = "正解 :" + GameSetting.collect_num.ToString() +"\n不正解 :" + GameSetting.incollect_num.ToString();
    }
}
