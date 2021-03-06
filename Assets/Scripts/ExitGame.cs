using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject ModalExit;
   
    public void ExitGamePlay(){
         #if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
     #else
         Application.Quit();
     #endif
        Debug.Log("Quit");
    }

    public void ModalExitGame(bool status){
        ModalExit.SetActive(status);
    }
  
}
