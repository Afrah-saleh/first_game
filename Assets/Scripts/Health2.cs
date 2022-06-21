using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health2 : MonoBehaviour
{
    
     [SerializeField] int Health=100;
      [SerializeField]  Text HealthText;

    private void Awake(){
       DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
   
    void Start()
    {
        
        if(HealthText==null){
       HealthText=GameObject.Find("Health").GetComponent<Text>();
        }
    }


  public void UpdateHealth(int value){
        Health -=20;
        HealthText.text=Health.ToString();
}

public void SetHealthText(Text aHealthText){
    HealthText=aHealthText;
HealthText.text=Health.ToString();
}

}