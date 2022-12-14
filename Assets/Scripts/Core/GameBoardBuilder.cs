using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardBuilder : MonoBehaviour
{

    [SerializeField] private Tile tilePrefab;

    public void BuildBoard()
    {
        for(int i = 0; i < 10; i++)
        {
            Tile newTile = Instantiate(tilePrefab, new Vector3(i, 0, 0), Quaternion.identity);
            newTile.transform.SetParent(this.transform);
            newTile.name = $"Tile {i}";
        }
    }
}
