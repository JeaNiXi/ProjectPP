using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameBoardBuilder boardBuilderPrefab;

    private void Awake()
    {
        if (Instance != null && Instance != this) 
            Destroy(this);
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        GameBoardBuilder mainGameBoard = Instantiate(boardBuilderPrefab, Vector3.zero, Quaternion.identity);
        mainGameBoard.BuildBoard();
    }
}
