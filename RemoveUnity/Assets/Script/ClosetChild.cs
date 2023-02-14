using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosetChild : MonoBehaviour
{
    public GameObject Cloth;
    private Image backGround;

    public Sprite Open;
    void Start()
    {
        backGround = gameObject.transform.parent.parent.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (backGround.sprite != Open)
        {
            Cloth.SetActive(false);
        }
    }
}
