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

    public static float volume = 0.5f;
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
                    Debug.Log("playingSound");
                }
                break;
            }
        }
    }
}
