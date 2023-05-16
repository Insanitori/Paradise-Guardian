using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlacer : MonoBehaviour
{
    //private RecordingCanvas rec;

    public Transform OfficeCam;
    public Transform KitchenCam;
    public Transform ExamCam;
    public Transform hiddingCam;

    private bool start;

    public bool hidden;
    public bool frozen;
    private bool clipDone;

    public bool test;

    public AudioClip tut1;
    public AudioClip tut2;

    public AudioClip breathing;

    public bool exam;
    public bool office;
    public bool kitchen;
    public bool Freeze;
    public bool hide; 

    // Start is called before the first frame update
    void Start()
    {
        frozen = false;
        hidden = false;
        clipDone = false;
        start = false;

        exam = false;
        office = false;
        kitchen = false;
        Freeze = false;
        hide = false;

        test = false;
        //rec = FindObjectOfType<RecordingCanvas>();
        transform.position = OfficeCam.position;

        StartCoroutine(tutorial());
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (exam)
            {
                transform.position = ExamCam.position;
                exam = false;
                hidden = false;
                frozen = false;
            }
            else if (office)
            {
                transform.position = OfficeCam.position;
                office = false;
                hidden = false;
                frozen = false;
            }
            else if (kitchen)
            {
                transform.position = KitchenCam.position;
                kitchen = false;
                hidden = false;
                frozen = false;
            }

            if (Freeze)
            {
                Freeze = false;
                frozen = true;
            }

            if (hide)
            {
                hide = false;
                hidden = true;
                transform.position = hiddingCam.position;
                AudioSource.PlayClipAtPoint(breathing, transform.position);
            }
        }

        if (test && clipDone)
        {
            AudioSource.PlayClipAtPoint(tut2, transform.position);
            start = true;
            GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().StartGame = true;
            FindObjectOfType<Monster>().begin = true;
            clipDone = false;
        }
    }

    public IEnumerator tutorial()
    {
        yield return new WaitForSeconds(2);
        AudioSource.PlayClipAtPoint(tut1, transform.position);
        yield return new WaitForSeconds(205);
        yield return new WaitForSeconds(3);
        clipDone = true;
    }
}
