using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{

    Vector2 init = new Vector2(-7.0f, -3.5f);



    float speed = 0.3f;
    float loc_x;
    float loc_y;

    float delta = 0;
    bool fire = true;
    // Use this for initialization
   
    void Start()
    {
         


}

// Update is called once per frame
void Update()
    {
        transform.Rotate(0, 0, 15);
        delta += Time.deltaTime;

        if (transform.position.x>6){
            if (transform.position.y < 2){

                
                Destroy(gameObject);

              
            }

        }

        if (transform.position.x > 8.0f)
        {

           this.fire = false;
            Destroy(gameObject);
        }

        if(this.fire){
            this.loc_x= transform.position.x;
            this.loc_y = transform.position.y;
            this.loc_x += this.speed;

            transform.position = new Vector2(this.loc_x, this.loc_y);

        }
      
    }
}