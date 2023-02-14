using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenCabinetRightChild : MonoBehaviour
{
   
    public GameObject drug;
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
            drug.SetActive(false);
        }
    }
}
