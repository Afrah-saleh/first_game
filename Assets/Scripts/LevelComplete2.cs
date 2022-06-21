using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete2 : MonoBehaviour
{


    public void NextBtn(){

    
        SceneManager.LoadScene("Level_2");
    }

  public void QuitBtn(){
      Application.Quit();
  }
}
