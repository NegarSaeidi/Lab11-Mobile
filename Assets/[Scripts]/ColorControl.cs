using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class ColorControl : MonoBehaviour
{
    public Color color;
    private List<SpriteRenderer> renderers;
    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponentsInChildren<SpriteRenderer>().ToList();
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ChangeColor()
    {

        foreach(var renderer in renderers)
        {
            renderer.material.SetColor("_Color", color);
        }
    }
    public void ChangeColor(Color color =new Color())
    {
        foreach (var renderer in renderers)
        {
            renderer.material.SetColor("_Color", color);
        }
    }
}

