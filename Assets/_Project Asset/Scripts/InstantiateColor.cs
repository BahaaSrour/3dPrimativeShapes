using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateColor : InstantiateShapesAndColorBtns<ShapeColor>
{
    public override GameObject[] InstantiateBtn()
    {
        GameObject[] ItemsList = base.InstantiateBtn();

        for (int i = 0; i < ItemsList.Length; i++)
        {
            ItemsList[i].GetComponent<Image>().color = lists.itemsList[i].shapeColor;
            ItemsList[i].GetComponent<ChangeColor>().colorValue = lists.itemsList[i];
        }
        return ItemsList;
    }
}
