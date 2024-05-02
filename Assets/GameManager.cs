using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] stone;
    string str;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 64; i++)
        {

            str=i.ToString();
            stone[i].name = str;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
