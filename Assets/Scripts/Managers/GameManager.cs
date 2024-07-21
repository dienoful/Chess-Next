using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    #region Public for Editor
    public void ReastartScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
    #endregion

    #region Protected functions for derivers
    protected void Awake()
    {
        
    }
    #endregion
}
