using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShapeMesh : MonoBehaviour
{
    public ShapeMesh changedShapeMesh;

    public void SetShapeMesh()
    {
        Shape.Instance.shapeMesh = changedShapeMesh;
    }
}
