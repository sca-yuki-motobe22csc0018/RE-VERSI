using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borad : MonoBehaviour
{
    public GameObject black;
    public GameObject white;
    public static bool a;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        a = true;
        button = GetComponent<Button>();
        black.SetActive(false);
        white.SetActive(false);
        button.onClick.AddListener(Click);
        if (this.tag == "StartBlack")
        {
            this.tag = "Black";
        }
        if (this.tag == "StartWhite")
        {
            this.tag = "White";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Black")
        {
            black.SetActive(true);
        }
        if (this.tag == "White")
        {
            white.SetActive(true);
        }
    }

    void Click()
    {
        if (this.tag == "Untagged")
        {
            if (a==true)
            {
                this.tag = "Black";
                a = false;
            }
            else
            {
                this.tag = "White";
                a = true;
            }
        }
    }
}
