using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Yarn.Unity
{
    public class Fade : MonoBehaviour
    {
        Image TestImage;
        Color tmpColor;

        void Start()
        {
            tmpColor = Color.black;
            tmpColor.a = 1f;
            TestImage = GetComponent<Image>();
            TestImage.color = tmpColor;
        }

        [YarnCommand("FadeIn")]
        public void FadeIn()
        { 
           if(Input.GetMouseButtonDown(0))
            {
                while (tmpColor.a <= 1f && tmpColor.a >= 0f)
                {
                    tmpColor.a -= 0.01f;
                    TestImage.color = tmpColor;
                    if (tmpColor.a == 0f) break;
                }
                Debug.Log("FadingIn");
            }

        }

        [YarnCommand("FadeOut")]
        public void FadeOut()
        {
            if(Input.GetMouseButtonDown(0))
            {
                while (tmpColor.a <= 1f && tmpColor.a >= 0f)
                {
                    tmpColor.a += 0.01f;
                    TestImage.color = tmpColor;
                    if (tmpColor.a == 0f) break;
                }
                Debug.Log("FadingOut");
            }
        }

    }
}