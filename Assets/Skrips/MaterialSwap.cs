using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class MaterialSwap : MonoBehaviour
{
    public Material _material;
    public Material swapMaterial;
    private MeshRenderer _meshRenderer;

    public bool used;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _meshRenderer.material = _material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _meshRenderer.material = swapMaterial;
            used = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _meshRenderer.material = _material;
        }
    }
}
