using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectabies2 : MonoBehaviour
{
[SerializeField] Renderer rd;
[SerializeField] GameManegar gm;
[SerializeField] int value=10;
 private void start()
 {
    rd= GetComponent<Renderer>();
    gm=GameObject.Find("GameManegar").GetComponent<GameManegar>();

 }
   private void OnTriggerEnter(Collider other){
       if(other.gameObject.name == "player"){
           gm.UpdateScore(value);
           //rd.enabled=false;
           Destroy(this.gameObject);
       }
    }

 }