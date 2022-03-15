using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperStrike : MonoBehaviour
{

    public Material normal;
    public Material toon;
    public GameObject outline;
    public GameObject outline2;
    private SkinnedMeshRenderer[] meshRenderers;
    private bool isNormal = true;
    private void Awake()
    {
        meshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    public void Toggle()
    {
        isNormal = !isNormal;

        foreach(SkinnedMeshRenderer meshRenderer in meshRenderers)
        {
            if (meshRenderer.material.name.Contains("eyes"))
            {
                continue;
            }

            if (isNormal)
            {
                meshRenderer.material = normal;
            }
            else
            {
                meshRenderer.material = toon;
            }
            
        }

        if (isNormal)
        {
            outline.SetActive(false);
            outline2.SetActive(false);
        }
        else
        {
            outline.SetActive(true);
            outline2.SetActive(true);
        }
    }
}
