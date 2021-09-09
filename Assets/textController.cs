using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController : MonoBehaviour
{
    public Text newText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) {
            newText.text = "Hello, my name is \nEdgardo Velazquez";
        } else {
            newText.text = "Hello World";
        }

        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }
}
