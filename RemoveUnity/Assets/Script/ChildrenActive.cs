using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildrenActive : MonoBehaviour
{
    public GameObject cakeBox;
    public GameObject water;
    public GameObject box;
    private Image backGround;

    public Sprite Open;
    // Start is called before the first frame update
    void Start()
    {
        backGround = gameObject.transform.parent.parent.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (backGround.sprite != Open)
        {
            cakeBox.SetActive(false);
            water.SetActive(false);
            box.SetActive(false);
        }
    }
}
