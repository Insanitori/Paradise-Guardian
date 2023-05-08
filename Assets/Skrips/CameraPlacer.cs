using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlacer : MonoBehaviour
{
    private RecordingCanvas rec;

    public Transform OfficeCam;
    public Transform KitchenCam;
    public Transform ExamCam;

    private bool start;

    public bool hidden;
    public bool frozen;
    // Start is called before the first frame update
    void Start()
    {
        frozen = false;
        hidden = false;
        rec = FindObjectOfType<RecordingCanvas>();
        transform.position = OfficeCam.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rec.Final == "Exam" || rec.Final == "exam")
        {
            transform.position = ExamCam.position;
            hidden = false;
            frozen = false;
        }
        else if (rec.Final == "Office" || rec.Final == "office")
        {
            transform.position = OfficeCam.position;
            hidden = false;
            frozen = false;
        }
        else if(rec.Final == "Kitchen" || rec.Final == "kitchen")
        {
            transform.position = KitchenCam.position;
            hidden = false;
            frozen = false;
        }

        if(rec.Final == "start" || rec.Final == "Start")
        {
            GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().StartGame = true;
            FindObjectOfType<Monster>().begin = true;
        }

        if(rec.Final == "Freeze" || rec.Final == "freeze")
        {
            frozen = true;
        }

        if (rec.Final == "Hide" || rec.Final == "hide")
        {
            hidden = true;
        }
    }
}
