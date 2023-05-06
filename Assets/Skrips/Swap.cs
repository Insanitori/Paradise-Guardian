using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    private bool disappear;
    private Vector3 originalPos;
    private Quaternion originalRot;
    public bool used;

    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        disappear = false;
        originalPos = transform.position;
        originalRot = transform.rotation;
        used = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(1000, 10, 1000);
            other.transform.position = originalPos;
            other.transform.rotation = originalRot;

            disappear = true;
            used = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            other.transform.position = new Vector3(1000, 10, 1000);
            transform.position = originalPos;
            disappear = false;
        }
    }
}
