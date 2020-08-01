using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Left_Right : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        Vector3 moveVector = (transform.forward * v) + (transform.right * h * 5);
        moveVector *= speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x < 5.2)
                transform.localPosition += moveVector;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localPosition.x  > -5.2)
                transform.localPosition += moveVector;
        }else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition += moveVector;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition += moveVector;
        }
    }
}
//character.transform.position = character.transform.position + new Vector3(0f, 0.05f, 0f);
