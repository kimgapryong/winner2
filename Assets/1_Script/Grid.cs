using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid <T>
{
    private int width;
    private int height;

    private T[,] girdArray;
    private GameObject[,] cellArray;
   public Grid(int width, int height, float cellSize, Transform parent, Sprite sprite)
    {
        this.width = width;
        this.height = height;
        girdArray = new T[width, height];
        cellArray = new GameObject[width, height];

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Vector3 pos = new Vector3(x * cellSize, y * cellSize ,0);
                cellArray[x, y] = MakeGameObject(pos, cellSize, parent, sprite);
            }
        }
        
    }

    private GameObject MakeGameObject(Vector3 pos, float size, Transform trans, Sprite sprite)
    {
        GameObject obj = new GameObject("GridCell", typeof(MeshFilter), typeof(MeshRenderer), typeof(SpriteRenderer));
        obj.transform.SetParent(trans);

        obj.transform.position = pos;
        obj.transform.localScale = new Vector3(size, size,0);

        obj.GetComponent<SpriteRenderer>().sprite = sprite;
        obj.GetComponent<MeshFilter>().mesh = MakeMesh(size);

        return obj;

    }

    private Mesh MakeMesh(float size)
    {
        Mesh mesh = new Mesh();

        Vector3[] verticals = new Vector3[4];
        int[] triangles = new int[6];
        Vector2[] uv = new Vector2[4];

        verticals[0] = new Vector3(0, 0);
        verticals[1] = new Vector3(0, 1);
        verticals[2] = new Vector3(1, 1);
        verticals[3] = new Vector3(1, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;

        return mesh;
    }
}
