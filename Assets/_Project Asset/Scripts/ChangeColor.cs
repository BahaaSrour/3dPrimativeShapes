using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public ShapeColor colorValue;

    public void SetShapeColor()
    {
        Shape.Instance.shapeColor = colorValue;
    }

}
