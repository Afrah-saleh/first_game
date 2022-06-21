using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall2 : MonoBehaviour
{
     private void OnTriggerEnter(Collider other){
          if(other.gameObject.name=="player")
          {
              SceneManager.LoadScene("Level_2");
          }
    // Start is called before the first frame update
   
     }}
