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
        // this.isLoad�ɂ���ƃG���[���o��
        if (isLoad)
        { // ���łɃ��[�h����Ă�����
            Destroy(this.gameObject); // �������g��j�����ďI��
            return;
        }
        isLoad = true; // ���[�h����Ă��Ȃ�������A�t���O�����[�h�ς݂ɐݒ肷��
        DontDestroyOnLoad(this.gameObject);
    }
}
