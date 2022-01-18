using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    Coroutine rotationCoroutine;
    //Rigidbody rb;
    public float SpeedFactor = .1f;
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            rotationCoroutine = StartCoroutine(GetMouseDir());
        if (Input.GetMouseButtonUp(1))
            StopCoroutine(rotationCoroutine);
    }

    IEnumerator GetMouseDir()
    {
        Vector2 mousePos = Input.mousePosition;
        while (true)
        {
            yield return new WaitForEndOfFrame();
            Vector2 dir = (Vector2)Input.mousePosition - mousePos;
            mousePos = Input.mousePosition;
            RotateShape(dir);
        }

    }

    private void RotateShape(Vector2 dir)
    {
          transform.Rotate((dir.y/Screen.height) *SpeedFactor, -1*(dir.x/Screen.width) * SpeedFactor,  0,Space.World);
        //rb.AddTorque((dir.y / Screen.height) * SpeedFactor, -1 * (dir.x / Screen.width) * SpeedFactor, 0, ForceMode.Impulse);
    }
}
