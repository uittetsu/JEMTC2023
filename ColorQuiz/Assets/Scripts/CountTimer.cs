using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountTimer : MonoBehaviour
{
    float timer = 3f;
    int a = 0;
    public AudioClip sound1;
    AudioSource audiosource;
    TextMeshProUGUI textmeshpro;

    // Start is called before the first frame update
    void Start()
    {
        this.audiosource = this.GetComponent<AudioSource>();
        this.textmeshpro = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.timer > 2)
        {
            this.textmeshpro.text = "3";
            this.textmeshpro.color = Color.red;
            if (this.a == 0)
            {
                this.audiosource.PlayOneShot(sound1);
                this.a++;
            }
        }
        else if (this.timer > 1)
        {
            this.textmeshpro.text = "2";
            this.textmeshpro.color = Color.green;
            if (this.a == 1)
            {
                this.audiosource.PlayOneShot(sound1);
                this.a++;
            }
        }
        else if (this.timer > 0)
        {
            this.textmeshpro.text = "1";
            this.textmeshpro.color = Color.blue;
            if (this.a == 2)
            {
                this.audiosource.PlayOneShot(sound1);
                this.a++;
            }
        }
        else
        {
            SceneManager.LoadScene("GameScene");
        }

        this.timer -= Time.deltaTime;
    }
}
