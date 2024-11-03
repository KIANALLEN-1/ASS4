using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusic : MonoBehaviour
{
    [SerializeField] private AudioClip ACIntro;
    [SerializeField] private AudioClip ACBGMMain;
    [SerializeField] private Canvas canvas;
    private AudioSource Intro;
    private AudioSource BGMMain;
    
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Intro = gameObject.AddComponent<AudioSource>();
        BGMMain = gameObject.AddComponent<AudioSource>();

        BGMMain.volume = 0.1f;
        
        
        Intro.clip = ACIntro;
        BGMMain.clip = ACBGMMain;
        
        
        Intro.Play();
        yield return new WaitForSeconds(Intro.clip.length);
    }

    // Update is called once per frame
    void Update()
    {
        if (!BGMMain.isPlaying && !Intro.isPlaying)
        {
            playMusic();
        }
    }

    void playMusic()
    {
        if (canvas!= null)
        {
            Intro.Play();
        }
        else
        {
            BGMMain.Play();
        }
    }
}
