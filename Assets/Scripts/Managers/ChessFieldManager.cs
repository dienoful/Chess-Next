using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChessFieldManager : GameManager
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


    private enum Pieces : int
    {
        None = 0,
        Pawn = 1,
        Rook = 2,
        Knight = 3,
        Bishop = 4,
        Queen = 5,
        King = 6
    }
    private Pieces[,] piecesPositions = new Pieces[,]
    {
        { Pieces.Rook, Pieces.Knight, Pieces.Bishop, Pieces.Queen, Pieces.King, Pieces.Bishop, Pieces.Knight, Pieces.Rook },
        { Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn },
        { Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None },
        { Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None },
        { Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None },
        { Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None, Pieces.None },
        { Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn, Pieces.Pawn },
        { Pieces.Rook, Pieces.Knight, Pieces.Bishop, Pieces.Queen, Pieces.King, Pieces.Bishop, Pieces.Knight, Pieces.Rook },
    };
    


    #region Default
    protected override void Awake()
    {
        InitChessField();
        InitChessPieces();
    }
    #endregion


    #region Private
    private void InitChessField()
    {
        for (int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                var cellPrefab = (i + j) % 2 == 0 ? whiteCell : blackCell;
                float xPos = -3.5f + i;
                float yPos = -3.5f + j;
                var newCell = Instantiate(cellPrefab);
                newCell.transform.position = new Vector3(xPos, yPos, 0.0f);

                if (newCell.TryGetComponent<Cell>(out var cellObject))
                {
                    cellObject.X = i;
                    cellObject.Y = j;
                }
            }
        }
    }
    private void InitChessPieces()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Pieces pieceId = piecesPositions[i, j];
                GameObject newCell = null;
                switch (pieceId)
                {
                    case Pieces.Pawn:
                        newCell = Instantiate(pawnPiece);
                        break;
                    case Pieces.Rook:
                        newCell = Instantiate(rookPiece);
                        break;
                    case Pieces.Knight:
                        newCell = Instantiate(knightPiece);
                        break;
                    case Pieces.Bishop:
                        newCell = Instantiate(bishopPiece);
                        break;
                    case Pieces.Queen:
                        newCell = Instantiate(queenPiece);
                        break;
                    case Pieces.King:
                        newCell = Instantiate(kingPiece);
                        break;
                    default:
                        break;
                }

                if (newCell != null)
                {
                    float xPos = -3.5f + j;
                    float yPos = -3.5f + i;
                    newCell.transform.position = new Vector3(xPos, yPos, 0.0f);
                }
            }
        }
    }
    #endregion
}
