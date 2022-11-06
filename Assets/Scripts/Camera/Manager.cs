using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] cameras = new GameObject[4];
    private int index = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            cameras[index].SetActive(false);
            index++;
            index = index % 4;
            cameras[index].SetActive(true);
        }
    }
}
