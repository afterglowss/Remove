using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip bgm;
    }

    public BgmType[] BgmList;

    static public MusicManager instance;
    public static float volume = 0.5f;
    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
        MusicManager.volume = volume;
    }
    public float GetMusicVolume()
    {
        return musicSource.volume;
    }
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
            Destroy(gameObject);
    }

    public void Update()
    {
        Scene nowScene = SceneManager.GetActiveScene();
        if (nowScene.name == "StartScene" && musicSource.isPlaying == false)
        {
            //for (int i = 0; i < BgmList.Length; i++)
            //{
            //    if (BgmList[i].name == "1")
            //    {
            //        musicSource.clip = BgmList[i].bgm;
            //        if (!musicSource.isPlaying)
            //        {
            //            musicSource.Play();
            //        }
            //        break;
            //    }
            //}
            PlayMusic("1");
        }
    }

    
    [YarnCommand("playMusic")]
    public void PlayMusic(string str)
    {
        for (int i = 0; i < BgmList.Length; i++)
        {
            if (str == BgmList[i].name)
            {
                musicSource.clip = BgmList[i].bgm;
                if (!musicSource.isPlaying)
                {
                    musicSource.Play();
                    Debug.Log("playingMusic");
                }
                break;
            }
        }
    }
    [YarnCommand("stopMusic")]
    public void StopMusic()
    {
        musicSource.Stop();
    }
    [YarnCommand("pauseMusic")]
    public void PauseMusic()
    {
        musicSource.Pause();
    }
    [YarnCommand("unPauseMusic")]
    public void UnPauseMusic()
    {
        musicSource.UnPause();
    }
    private float previousVolume;

    [YarnCommand("musicFadeOut")]
    public void MusicFadeOut()      //¼Ò¸® Á¡Á¡ ÀÛ¾ÆÁü
    {
        previousVolume = GetMusicVolume();
        StartCoroutine(MusicFadeOutCoroutine());
    }
    IEnumerator MusicFadeOutCoroutine()     
    {
        float FadeCount = previousVolume;
        while (FadeCount > 0)
        {
            FadeCount -= 0.01f;
            yield return new WaitForSeconds(0.0005f);
            SetMusicVolume(FadeCount);
        }
        PauseMusic();
        SetMusicVolume(previousVolume);
    }
    [YarnCommand("musicFadeIn")]
    public void MusicFadeIn()       //¼Ò¸® Á¡Á¡ Ä¿Áü
    {
        previousVolume = GetMusicVolume();
        StartCoroutine(MusicFadeInCoroutine());
    }
    IEnumerator MusicFadeInCoroutine()
    {
        float FadeCount = 0;
        UnPauseMusic();
        while (FadeCount < previousVolume)
        {
            FadeCount += 0.01f;
            yield return new WaitForSeconds(0.0005f);
            SetMusicVolume(FadeCount);
        }
    }
}
