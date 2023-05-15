using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class MaterialSwap : MonoBehaviour
{
    public Material _material;
    public Material swapMaterial;
    private MeshRenderer _meshRenderer;

    //private RecordingCanvas rec;

    public bool swapMesh;
    public bool used;
    // Start is called before the first frame update
    void Start()
    {
        //rec = FindObjectOfType<RecordingCanvas>();
        _meshRenderer = GetComponent<MeshRenderer>();

        _meshRenderer.material = _material;
        swapMesh = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (swapMesh)
        {
            _meshRenderer.material = swapMaterial;
            used = true;

            if (FindObjectOfType<GameManaging>().OM)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
                {
                    swapMesh = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);
                    
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;

                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().OM = false;
            }

            if (FindObjectOfType<GameManaging>().EM)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam > 0)
                {
                    swapMesh = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().EM = false;
            }

            if (FindObjectOfType<GameManaging>().KM)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen > 0)
                {
                    swapMesh = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().KM = false;
            }
        }

        if (!swapMesh)
        {
            _meshRenderer.material = _material;
        }
    }
}
