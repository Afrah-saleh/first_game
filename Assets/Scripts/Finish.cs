using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{


    public void StarttBtn(){

    
        SceneManager.LoadScene("Start");
    }

  public void QuitBtn(){
     Application.Quit();
  }
}
