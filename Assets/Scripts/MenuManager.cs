using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //Funciona para cargar el primer nivel
    public void LoadLVL1()
    {
        SceneManager.LoadScene("Nivel1");
    }
  //Funciona para cargar el menu principal
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
