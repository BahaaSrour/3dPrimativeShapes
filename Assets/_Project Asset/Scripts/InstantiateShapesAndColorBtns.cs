using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateShapesAndColorBtns<T>  : MonoBehaviour where T: NameClass 
{
    public ListSO<T> lists;
    public GameObject btnPrefab;
    public Transform Parent;
    public virtual GameObject[] InstantiateBtn()
    {
        GameObject[] ItemsList = new GameObject[lists.Count];
        for (int i = 0; i < lists.Count; i++)
        {
            ItemsList[i] = GameObject.Instantiate(btnPrefab, Parent);
            ItemsList[i].GetComponentInChildren<TMPro.TextMeshProUGUI>().text = lists.itemsList[i].name;
        }
        return ItemsList;
    }
    private void Start()
    {
        InstantiateBtn();
    }
}
