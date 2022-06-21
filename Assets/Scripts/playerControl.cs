using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerControl : MonoBehaviour
{
    [SerializeField] float Speed =2;
    [SerializeField] Rigidbody rb;
    [SerializeField] float JumpForce=7;
    [SerializeField] bool onGround =true;
    // Start is called before the first frame update
  //private  void Awake(){
     //   DontDestroyOnLoad(this.gameObject);
 //   }

    void Start()
    {
    rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move player's character in the direction of the player's input
        //use rigierdbody
        //transfore.position
        //transform.translate
if(Input.GetAxis("Horizontal")!=0||Input.GetAxis("Vertical")!=0)
{


      float  moveHorizontal = Input.GetAxis("Horizontal");
      float  moveVertical = Input.GetAxis("Vertical");

         transform.Translate(moveHorizontal*Speed* Time.deltaTime,0,moveVertical*Speed* Time.deltaTime);

    }

    if(Input.GetButtonDown("Jump")&& onGround){
 rb.AddForce(new Vector3(0.0f,JumpForce,0.0f), ForceMode.Impulse);
onGround=false;
     
    }
}
private void OnCollisionEnter(Collision Collection){
onGround=true;

}
}

