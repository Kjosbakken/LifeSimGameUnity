using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public SpriteRenderer sr;

    public clothingshop cs;

    public Transform playerPosition;
    public Transform spawnPositionRight;
    public Transform spawnPositionLeft;


    public Transform spawnPosition;

    public string trigger = "";
    public float radius = 2f;

    public GameObject menuUI;

    public GameObject casinoPosition;
    public GameObject casinoUI;

    public GameObject jobPosition;
    public GameObject jobScreenUI;

    public GameObject stocksPosition;
    public GameObject stocksUI;

    public GameObject home1Position;
    public GameObject home1UI;

    public GameObject home2Position;
    public GameObject home2UI;

    public GameObject busPosition;
    public GameObject busUI;

    public GameObject clothingPosition;
    public GameObject clothingUI;


    public Text money;
    public Text energy;

    
    

    public void activeButton()
    {

        float distToJobScreen = Vector2.Distance(playerPosition.position, jobPosition.transform.position);
        if (distToJobScreen < radius)
        {
            Time.timeScale = 0f;
            jobScreenUI.SetActive(true);
        }

        float distToStockScreen = Vector2.Distance(playerPosition.position, stocksPosition.transform.position);
        if (distToStockScreen < radius)
        {
            Time.timeScale = 0f;
            stocksUI.SetActive(true);
        }

        float distToHome1Screen = Vector2.Distance(playerPosition.position, home1Position.transform.position);
        if (distToHome1Screen < radius)
        {
            Time.timeScale = 0f;
            home1UI.SetActive(true);
        }

        float distToCasino = Vector2.Distance(playerPosition.position, casinoPosition.transform.position);
        if (distToCasino < radius)
        {
            Time.timeScale = 0f;
            casinoUI.SetActive(true);
        }

        float distToBusScreen = Vector2.Distance(playerPosition.position, busPosition.transform.position);
        if (distToBusScreen < radius)
        {
            Time.timeScale = 0f;
            busUI.SetActive(true);
        }

        float distToClothingScreen = Vector2.Distance(playerPosition.position, clothingPosition.transform.position);
        if (distToClothingScreen < radius)
        {
            Time.timeScale = 0f;
            clothingUI.SetActive(true);
        }

        float distToHome2 = Vector2.Distance(playerPosition.position, home2Position.transform.position);
        if (distToHome2 < radius)
        {
            Time.timeScale = 0f;
            home2UI.SetActive(true);
        }

    }
    public void Update()
    {

        money.text = Data.money.ToString("0");
        energy.text = Data.energy.ToString("0");

        /*

        float distToCasino = Vector2.Distance(playerPosition.position, casinoPosition.transform.position);
        if (distToCasino < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            casinoUI.SetActive(true);
        }

        
         

        float distToJobScreen = Vector2.Distance(playerPosition.position, jobPosition.transform.position);

        if (distToJobScreen < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            jobScreenUI.SetActive(true);
        }

        float distToStockScreen = Vector2.Distance(playerPosition.position, stocksPosition.transform.position);

        if (distToStockScreen < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            stocksUI.SetActive(true);
        }

        float distToHome1Screen = Vector2.Distance(playerPosition.position, home1Position.transform.position);

        if (distToHome1Screen < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            home1UI.SetActive(true);
        }


    
        float distToBusScreen = Vector2.Distance(playerPosition.position, busPosition.transform.position);

        if (distToBusScreen < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            busUI.SetActive(true);
        }

        float distToClothingScreen = Vector2.Distance(playerPosition.position, clothingPosition.transform.position);

        if (distToClothingScreen < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            clothingUI.SetActive(true);
        }
        
        float distToHome2 = Vector2.Distance(playerPosition.position, home2Position.transform.position);

        if (distToHome2 < radius && Input.GetKeyDown(KeyCode.G))
        {
            Time.timeScale = 0f;
            home2UI.SetActive(true);
        }

        */

    }





    void OnEnable()
    {
        //Tell the 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell the 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {

        playerPosition.position = spawnPosition.position;

        cs.activateActiveSkin();

        /*
        
        if (trigger == "endTrigger")
        {
            playerPosition.position = spawnPositionLeft.position;
            trigger = "";
        }

        else if (trigger == "startTrigger")
        {
            playerPosition.position = spawnPositionRight.position;
            trigger = "";
        }
        */





    }

    public void loadNextLevel()
    {
        // pass på at du ikke kan gå lenger enn antall scenes
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // spawnpoint = start
    }

    public void loadPrevLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //spawnpoint = end
        }

        // opening different UI's

    }

    public void loadLevel(int level)
    {
        
        SceneManager.LoadScene(level);
    }














    //ekstra greier som kanskje burde flyttes

    public void openMenuUI()
    {
        Time.timeScale = 0f;
        menuUI.SetActive(true);
    }

    public void resumeFromMenu()
    {
        Time.timeScale = 1f;
        menuUI.SetActive(false);
    }

    public void resumeFromJobScreen()
    {
        Time.timeScale = 1f;
        jobScreenUI.SetActive(false);
    }

    public void resumeFromStockScreen()
    {
        Time.timeScale = 1f;
        stocksUI.SetActive(false);
    }

















}
