using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public static string t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score = GameObject.Find("Canvas/Score").GetComponent<Text>();

        t = score.text;
    }
}
