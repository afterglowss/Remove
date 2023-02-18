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
            for (int i = 0; i < BgmList.Length; i++)
            {
                if (BgmList[i].name == "1")
                {
                    musicSource.clip = BgmList[i].bgm;
                    if (!musicSource.isPlaying)
                    {
                        musicSource.Play();
                    }
                    break;
                }
            }
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
    //[YarnCommand("playRepeatMusic")]
    //public void PlayRepeatMusic(string str)
    //{
    //    for (int i = 0; i < BgmList.Length; i++)
    //    {
    //        if (str == BgmList[i].name)
    //        {
    //            musicSource.clip = BgmList[i].bgm;
    //            if (!musicSource.isPlaying)
    //            {
    //                musicSource.loop = true;
    //                musicSource.Play();
    //                Debug.Log("playingMusic");
    //            }
    //            break;
    //        }
    //    }
    //}
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
}
