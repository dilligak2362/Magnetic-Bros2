/** Import Libraries **/
using System; //C# library for system properties
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //libraries for accessing scenes


public class GameManager : MonoBehaviour
{
    /*** VARIABLES ***/

    #region GameManagerSingleton
    static private GameManager gm; //refence GameManager
    static public GameManager GM { get { return gm; } } //public access to read only gm 

    //Check to make sure only one gm of the GameManager is in the scene
    void CheckGameManagerIsInScene()
    {

        //Check if instnace is null
        if (gm == null)
        {
            gm = this; //set gm to this gm of the game object
            Debug.Log(gm);
        }
        else //else if gm is not null a Game Manager must already exsist
        {
            Destroy(this.gameObject); //In this case you need to delete this gm
        }
        DontDestroyOnLoad(this); //Do not delete the GameManager when scenes load
        Debug.Log(gm);
    }//end CheckGameManagerIsInScene()
    #endregion

    [Header("SCENE SETTINGS")]
    [Tooltip("Name of the start scene")]
    public string startScene;

    [Tooltip("Name of the game over scene")]
    public string gameOverScene;

    [Tooltip("Count and name of each Game Level (scene)")]
    public string gameLevel; //names of level
    [HideInInspector]
    private int loadLevel; //what level from the array to load


    public static string currentSceneName;

    [HideInInspector]
    public bool won = false;

    void Awake()
    {
        CheckGameManagerIsInScene();

        currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

    }

    void Update()
    {
        if (Input.GetKey("escape")) { ExitGame(); }
    }



    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }//end ExitGame()

    public void StartGame()
    {
        Debug.Log("Loading level " + gameLevel);

        won = false;
        SceneManager.LoadScene(gameLevel);
    }

    public void GameOver()
    {

        SceneManager.LoadScene(gameOverScene);
    }
}