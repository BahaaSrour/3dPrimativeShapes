using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Shape : MonoBehaviour
{
    static Shape instance;
    static string JsonFilePath;

    public ShapeColor shapeColor;
    public ShapeMesh shapeMesh;
    public ShapesList shapesList;
    public ColorList colorList;
    public static Shape Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        JsonFilePath = Application.dataPath + "Settings.Json";
        Load();
    }

    public void Save()
    {
        if (File.Exists(JsonFilePath))
            File.Delete(JsonFilePath);
        File.WriteAllText(JsonFilePath, JsonUtility.ToJson(new ShapeData { ColorName = shapeColor.name , MeshName = shapeMesh.name }));
    }

    public void Load()
    {
        if (File.Exists(JsonFilePath))
        {
            var tmp= JsonUtility.FromJson<ShapeData>(File.ReadAllText(JsonFilePath));
            this.shapeColor = colorList.GetItemByName( tmp.ColorName);
            this.shapeMesh = shapesList.GetItemByName( tmp.MeshName);
            UpdateShapeProperties();
        }
    }
    public void UpdateShapeProperties()
    {
        GetComponent<MeshFilter>().mesh = shapeMesh.shapeMesh;
        GetComponent<Renderer>().material.color = shapeColor.shapeColor;
    }
    private void OnDestroy()
    {
        Save();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
            Save();
        if (Input.GetKey(KeyCode.L))
            Load();
    }
}

public class NameClass
{
    public string name;
}

[System.Serializable]
public struct ShapeData
{
    public string MeshName;
    public string ColorName;
}