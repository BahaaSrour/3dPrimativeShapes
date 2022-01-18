using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    static Shape instance;
    public ShapeColor shapeColor;
    public ShapeMesh shapeMesh;

    public static Shape Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }


    public void UpdateShapeProperties()
    {
        GetComponent<MeshFilter>().mesh = shapeMesh.shapeMesh;
        GetComponent<Renderer>().material.color = shapeColor.shapeColor;
    }
}

public class NameClass
{
    public string name;
}