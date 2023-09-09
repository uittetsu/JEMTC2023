using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDirector : MonoBehaviour
{
    private static bool isLoad = false;

    public AudioClip collect_sound;
    public AudioClip incollect_sound;
    public AudioClip question_sound;

    // Start is called before the first frame update
    void Start()
    {
        //Awake();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
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
