/****
*Created by: Bridget Kurr
*Date Created: 09/25/22
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuScript : MonoBehaviour
{
    [Header("Text Boxes")]
    public TMP_Text titleTextbox; //textbox for title
    public TMP_Text creditsTextbox; //textbox for credits
    public TMP_Text copyrightTextbox; //texbox for copyright
    public TMP_Text messageTextbox; //textbox for end message

    // Start is called before the first frame update
    void Start()
    {
        //Set the values for textboxes
    }

   public void OnGameStart()
    {
        Debug.Log("Game Started");
    }// end ongamestart()

    public void OnGameExit()
    {
        Debug.Log("Game Exited");
    }
}
