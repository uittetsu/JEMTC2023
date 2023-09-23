using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StartBGMDirector : MonoBehaviour
{
    private static bool startBGMisLoad = false;// 自身がすでにロードされているかを判定するフラグ
    public static bool startBGMflag = false;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (startBGMflag)
        {
            startBGMflag = false;
            this.GetComponent<AudioSource>().Stop();
            startBGMisLoad = false;
            Destroy(this.gameObject);
        }
    }
    
    private void Awake()
    {
        if (startBGMisLoad)
        { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        startBGMisLoad = true; // ロードされていなかったら、フラグをロード済みに設定する
        DontDestroyOnLoad(this.gameObject);
    }
}
