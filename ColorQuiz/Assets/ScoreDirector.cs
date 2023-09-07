using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDirector : MonoBehaviour
{
    public static int collect_num = 0;
    public static int incollect_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "collect :" + collect_num.ToString() +"\nincollect :" + incollect_num.ToString();
    }
}
