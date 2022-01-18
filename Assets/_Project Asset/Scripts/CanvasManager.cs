using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    public ScriptalbeEvent colorEvent;
    public ScriptalbeEvent shapeEvent;

    public GameObject colorUIPanel;
    public GameObject shapeUIPanel;

    private void Awake()
    {
        colorEvent.AddListener(DisableColorPanal);
        shapeEvent.AddListener(EnableColorPanal);
    }

    private void OnDestroy()
    {
        colorEvent.RemoveListener(DisableColorPanal);
        shapeEvent.RemoveListener(EnableColorPanal);
    }
    public void EnableColorPanal()
    {
        colorUIPanel.SetActive(true);
        shapeUIPanel.SetActive(false);
    }    public void  DisableColorPanal()
    {
        Shape.Instance.UpdateShapeProperties();
        colorUIPanel.SetActive(false);
    }
}
