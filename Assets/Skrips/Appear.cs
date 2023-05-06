using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    private bool appear;
    private Vector3 original;
    public bool used;
    // Start is called before the first frame update
    void Start()
    {
        appear = false;
        original = transform.position;
        used = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = original;
            appear = true;
            used = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(1000, 10, 1000);
            appear = false;
        }
    }
}
