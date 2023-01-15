using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;
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
        if (nowScene.name == "StoryStart")
        {
            musicSource.Stop();
        }
    }
    //private GameObject[] musics;

    //private void Awake()
    //{
    //    musics = GameObject.FindGameObjectsWithTag("Music");
    //    if (musics.Length >= 2)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    DontDestroyOnLoad(transform.gameObject);
    //    musicSource=GetComponent<AudioSource>();
    //}

    //public void PlayMusic()
    //{
    //    if (musicSource.isPlaying) return;
    //    musicSource.Play();
    //}
    //public void StopMusic()
    //{
    //    musicSource.Stop();
    //}
}
