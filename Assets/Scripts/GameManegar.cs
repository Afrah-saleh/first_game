using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManegar : MonoBehaviour
{
    [SerializeField] int Score=0;
    [SerializeField] Text ScoreText;

    private void Awake(){
       DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
   
    void Start()
    {
        if(ScoreText==null){
       ScoreText=GameObject.Find("Score").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    //public void UpdateScore(int value)
   // Score +=value;
    public void UpdateScore(int value){
        Score +=value;
        ScoreText.text=Score.ToString();
}

public void SetScoreText(Text aScoreText){
ScoreText=aScoreText;
ScoreText.text=Score.ToString();
}

}