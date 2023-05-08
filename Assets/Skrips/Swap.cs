using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public bool disappear;
    private Vector3 originalPos;
    private Quaternion originalRot;
    public bool used;

    public GameObject other;

    private RecordingCanvas rec;
    // Start is called before the first frame update
    void Start()
    {
        rec = FindObjectOfType<RecordingCanvas>();
        disappear = false;
        originalPos = transform.position;
        originalRot = transform.rotation;
        used = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (disappear)
        {
            transform.position = new Vector3(1000, 10, 1000);
            other.transform.position = originalPos;
            other.transform.rotation = originalRot;

            used = true;

            if (rec.Final == "Office Changed" || rec.Final == "office changed" || rec.Final == "office Changed" || rec.Final == "Office changed")
            {
                if(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
                {
                    disappear = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;

                }
            }

            if (rec.Final == "Exam Changed" || rec.Final == "exam changed" || rec.Final == "exam Changed" || rec.Final == "Exam changed")
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam > 0)
                {
                    disappear = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
            }

            if (rec.Final == "Kitchen Changed" || rec.Final == "kitchen changed" || rec.Final == "kitchen Changed" || rec.Final == "Kitchen changed")
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen > 0)
                {
                    disappear = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
            }
        }

        if (!disappear)
        {
            other.transform.position = new Vector3(1000, 10, 1000);
            transform.position = originalPos;
        }
    }
}
