using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject character;

    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - character.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = character.transform.position + distance;
    }
}
