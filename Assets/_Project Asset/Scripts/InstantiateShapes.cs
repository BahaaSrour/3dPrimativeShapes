using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateShapes : InstantiateShapesAndColorBtns<ShapeMesh>
{
    public override GameObject[] InstantiateBtn()
    {
        GameObject[] ItemsList = base.InstantiateBtn();

        for (int i = 0; i < ItemsList.Length; i++)
        {
            ItemsList[i].GetComponent<ChangeShapeMesh>().changedShapeMesh = lists.itemsList[i];
        }
        return ItemsList;
    }
}
