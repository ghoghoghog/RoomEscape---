using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefeb;
    [SerializeField] private Transform tilesParent;

    private Vector2Int puzzleSize = new Vector2Int(4, 4);

    private void Start()
    {
        SpawnTiles();
    }

    private void SpawnTiles()
    {
        for (int y = 0; y < puzzleSize.y; y++)
        {
            for (int x = 0; x < puzzleSize.x; x++)
            {
                GameObject clone = Instantiate(tilePrefeb, tilesParent);
                Tile tile = clone.GetComponent<Tile>();

                tile.Setup(puzzleSize.x * puzzleSize.y, y * puzzleSize.x + x + 1);
            }
        }
    }

    private IEnumerator OnSuffle()
    {
        float current = 0;
        float percent = 0;
        float time = 0;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current / time;
            //int index = Random.Range(0,);
        }
    }


}
