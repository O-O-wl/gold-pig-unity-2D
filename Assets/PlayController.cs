using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour {


    // Use this for initialization
    string dir = "right";
    bool jump = false;
    float jumpUp = 3.5f;

    void Start()
    {

    }

	
	// Update is called once per frame
	void Update () {

        
        if((this.jump)&&(transform.position.y< this.jumpUp))
        {
          
            transform.Translate(0, 0.1f, 0);
          
        }
        else if (transform.position.y>= this.jumpUp)
        {
            jump = false;


        }

        if((this.jump==false)&&(transform.position.y>-3.3)){
          
                transform.Translate(0, -0.1f, 0);
          
        }


        if(Input.GetKeyDown(KeyCode.Space)){
            
         
                this.jump = true;
           
           
        }






        if(Input.GetKey(KeyCode.LeftArrow)){
            if (this.dir=="right")
            {            
                //R R

                {
                transform.Translate(0.09f, 0, 0);
                dir = "left";
                transform.Rotate(180, 0, 180);
                } //
            }
            else
            {
                //L S 
                if (transform.position.x > -8)
                {
                    transform.Translate(-0.09f, 0, 0);
                }

            }
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            if (this.dir=="left")
            {   //L S 
                dir = "right";
                transform.Translate(0.09f, 0, 0);
                transform.Rotate(180, 0, 180);
            }
            else
            {   
                // R R 
                if(transform.position.x<8){
                transform.Translate(-0.09f, 0, 0);
                }
            }
        }




    }
}
