using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StartBGMDirector : MonoBehaviour
{
    private static bool startBGMisLoad = false;// ���g�����łɃ��[�h����Ă��邩�𔻒肷��t���O
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
        { // ���łɃ��[�h����Ă�����
            Destroy(this.gameObject); // �������g��j�����ďI��
            return;
        }
        startBGMisLoad = true; // ���[�h����Ă��Ȃ�������A�t���O�����[�h�ς݂ɐݒ肷��
        DontDestroyOnLoad(this.gameObject);
    }
}
