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
