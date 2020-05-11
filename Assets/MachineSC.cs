using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineSC : MonoBehaviour
{

    public int id = 0;
    public Texture[] images;

    private void Update()
    {
        gameObject.GetComponent<Renderer>().material.mainTexture = images[id];
    }

    private void OnMouseDown()
    {
        
    }
}
