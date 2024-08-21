using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject gridObj;
    public Sprite sprite;
    private Grid<int> grid;

    private void Start()
    {
        grid = new Grid<int>(2, 5, 5, gridObj.transform, sprite);
    }

}
