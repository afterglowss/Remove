using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SoundManager : MonoBehaviour
{
    //public static AudioSource soundSource { get => instance._soundSource; }
    public AudioSource soundSource;
    [System.Serializable]
    public struct SoundType
    {
        public string name;
        public AudioClip sound;
    }

    public SoundType[] SoundList;

    public static float volume = 0.2f;
    public static SoundManager instance;

    public void SetSoundVolume(float volume)
    {
        SoundManager.volume = volume;
        soundSource.volume = volume;
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
    [YarnCommand("playSound")]
    public void PlaySound(string str)
    {
        for (int i=0; i < SoundList.Length; i++)
        {
            if (str == SoundList[i].name)
            {
                soundSource.clip = SoundList[i].sound;
                if (!soundSource.isPlaying)
                {
                    soundSource.Play();
                }
                break;
            }
        }
    }
    [YarnCommand("playRepeatSound")]
    public void PlayRepeatSound(string str)
    {
        for (int i = 0; i < SoundList.Length; i++)
        {
            if (str == SoundList[i].name)
            {
                soundSource.clip = SoundList[i].sound;
                if (!soundSource.isPlaying)
                {
                    soundSource.loop = true;
                    soundSource.Play();
                }
                break;
            }
        }
    }
    [YarnCommand("stopSound")]
    public void StopSound()
    {
        soundSource.loop = false;
        soundSource.Stop();
    }
    private void Update()
    {
        
    }
}
