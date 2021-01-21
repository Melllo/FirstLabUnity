using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTri : MonoBehaviour
{
    public GameObject Triangle;
    public Vector2 pos1;
    public Vector2 pos2;
    public float step;
    public float progress;

    int x;
    int y;
    void Start()
    {
        Triangle.transform.position = pos1;
    }

    void Update()
    {
        Vector3 point = new Vector3(5, 0, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        Triangle.transform.position = Vector2.Lerp(pos1, pos2, progress * Time.deltaTime);
        progress += step;
        Triangle.transform.RotateAround(point, axis, Time.deltaTime * 30);
    }
}
