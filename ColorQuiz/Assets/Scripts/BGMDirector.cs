using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BGMDirector : MonoBehaviour
{
    private static bool isLoad = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSetting.remaining_time > 10f)
        {
            this.GetComponent<AudioSource>().pitch = 0.5f;
        }
        else if (GameSetting.remaining_time <= 10f &&  GameSetting.remaining_time > 5f)
        {
            this.GetComponent<AudioSource>().pitch = 1f;
        }
        else
        {
            this.GetComponent<AudioSource>().pitch = 2f;
        }
        
    }
    private void Awake()
    {
        // this.isLoadにするとエラーが出る
        if (isLoad)
        { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        isLoad = true; // ロードされていなかったら、フラグをロード済みに設定する
        DontDestroyOnLoad(this.gameObject);
    }
}
