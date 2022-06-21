using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneSetting : MonoBehaviour
{
     [SerializeField] GameManegar gm;
    [SerializeField] Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
      gm=GameObject.Find("GameManegar").GetComponent<GameManegar>();  
      ScoreText=GameObject.Find("Score").GetComponent<Text>();
      if(gm!=null)
      {
          gm.SetScoreText(ScoreText);
          
      }
    }

    
}
