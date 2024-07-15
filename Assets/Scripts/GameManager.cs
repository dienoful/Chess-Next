using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> fieltTypes = new List<GameObject>();

    #region Public
    public void ReastartScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
    #endregion

    #region Default
    private void Awake()
    {
        InitChessField();
    }
    #endregion

    #region Private
    private void InitChessField()
    {
        for (int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                int cellIndex = (i + j) % 2 == 0 ? 0 : 1;
                float xPos = -3.5f + i;
                float yPos = -3.5f + j;
                var newCell = Instantiate(fieltTypes[cellIndex]);
                newCell.transform.position = new Vector3(xPos, yPos, 0.0f);

                var cellObject = newCell.GetComponent<Cell>();
                if (cellObject != null )
                {
                    cellObject.X = i;
                    cellObject.Y = j;
                }
            }
        }
    }
    #endregion
}
