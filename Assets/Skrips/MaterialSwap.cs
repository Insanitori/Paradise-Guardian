using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class MaterialSwap : MonoBehaviour
{
    public Material _material;
    public Material swapMaterial;
    private MeshRenderer _meshRenderer;

    private RecordingCanvas rec;

    public bool swapMesh;
    public bool used;
    // Start is called before the first frame update
    void Start()
    {
        rec = FindObjectOfType<RecordingCanvas>();
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

            if (rec.Final == "Office Color" || rec.Final == "office color" || rec.Final == "office Color" || rec.Final == "Office color")
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
                {
                    swapMesh = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;

                }
            }

            if (rec.Final == "Exam Color" || rec.Final == "exam color" || rec.Final == "exam Color" || rec.Final == "Exam color")
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam > 0)
                {
                    swapMesh = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
            }

            if (rec.Final == "Kitchen Color" || rec.Final == "kitchen color" || rec.Final == "kitchen Color" || rec.Final == "Kitchen color")
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen > 0)
                {
                    swapMesh = false;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
            }
        }

        if (!swapMesh)
        {
            _meshRenderer.material = _material;
        }
    }
}
