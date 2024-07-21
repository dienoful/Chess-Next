using Assets.Scripts.Controllers;
using Assets.Scripts.Managers;
using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChessFieldManager : FieldManager
{
    // Field
    [Header("Feild")]
    [SerializeField] GameObject whiteCell;
    [SerializeField] GameObject blackCell;
    // Pieces
    [Header("Pieces")]
    [SerializeField] GameObject pawnPiece;
    [SerializeField] GameObject rookPiece;
    [SerializeField] GameObject knightPiece;
    [SerializeField] GameObject bishopPiece;
    [SerializeField] GameObject queenPiece;
    [SerializeField] GameObject kingPiece;

    private readonly int _width = 8;
    private readonly int _height = 8;
    private Field _field;
    private readonly int[,] _cellMap = new int[,] // 0 = white, 1 = black
    {
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1, 0 },
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1, 0 },
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1, 0 },
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1, 0 },
    };

    private Vector2 GetVisualCoordinates(int x, int y)
    {
        return new Vector2(x - 3.5f, y - 3.5f);
    }

    #region Default
    protected override void Awake()
    {
        _field = new Field(_width, _height);

        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                int cellType = _cellMap[x, y];
                GameObject cellObject = Instantiate(cellType == 0 ? whiteCell : blackCell);
                cellObject.transform.position = GetVisualCoordinates(x, y);
                if (cellObject.TryGetComponent<CellController>(out var cellController))
                {
                    cellController.Cell = _field.GetCell(x, y);
                }
            }
        }
    }
    #endregion
}
