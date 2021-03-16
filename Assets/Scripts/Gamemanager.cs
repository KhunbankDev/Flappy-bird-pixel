using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject ModalGameOver,ModalPause,BtnPause;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

   public void GameOver(){
       ModalGameOver.SetActive(true);
       BtnPause.SetActive(false);
       Time.timeScale = 0;
   }

   public void GamePause(){
       ModalPause.SetActive(true);
       Time.timeScale = 0;
   }

    public void GameResume(){
        ModalPause.SetActive(false);
       Time.timeScale = 1;
   }

   public void GameReplay(){
       ManageScene loadScene = new ManageScene();
       loadScene.LoadSceneIndex(1);
   }
}
