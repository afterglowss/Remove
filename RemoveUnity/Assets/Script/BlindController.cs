using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlindController : MonoBehaviour
{
    private Transform blind;

    private Vector3 Target;
    private Vector3 Target2;
    public void Awake()
    {
        blind = GetComponent<Transform>();
        Target = new Vector3(38.842f, 3.509f, 0);
    }
    
    public void Up()
    {
        if (Target == new Vector3(38.842f, 3.509f, 0))
        {
            Target = new Vector3(38.842f, 5.61f, 0);
        }
        else if (Target == new Vector3(38.842f, 5.61f, 0))
        {
            Target = new Vector3(38.842f, 7.87f, 0);
        }
        else
        {
            Target = new Vector3(38.842f, 3.509f, 0);
        }
    }
    //public void Up2()
    //{
    //    Target = new Vector3(38.83f, 8.3f, 0);
    //}

    public void Update()
    {

        blind.position = Vector3.MoveTowards(blind.position, 
            Target, 0.3f);
    }

    
}
