using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SoundSetVolume : MonoBehaviour
{
    public Slider soundSlider;
    private AudioSource soundSource;


    private void Awake()
    {
    }
    void Start()
    {
        soundSource = SoundManager.instance.soundSource;
        soundSlider.value = SoundManager.volume;
    }

    public void SetSoundVolume(float volume)
    {
        SoundManager.instance.SetSoundVolume(volume);
    }

    //[YarnCommand("playSound")]
    //public void PlaySound(string str)
    //{
    //    AudioClip audioClip;
    //    audioClip = (AudioClip)Resources.Load(str, typeof(AudioClip));
    //    soundSource.clip = audioClip;
    //    if (!soundSource.isPlaying)
    //    {
    //        soundSource.Play();
    //    }
    //}
}
