using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{

    // Use this for initialization
    Vector3 scence1 = new Vector3(-0.06f, -0.06f, 0);
    Vector3 scence2 = new Vector3(-0.06f, 0.06f, 0);
    Vector3 scence3 = new Vector3(0.06f, -0.06f, 0);
    Vector3 scence4 = new Vector3(0.06f, 0.06f, 0);
    Vector3 scence5 = new Vector3(0, 0, 0);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int nowScene = Random.Range(1, 6);

        if (nowScene == 1)
        {
            transform.position = this.scence1;
        }

        else if (nowScene == 2)
        {
            transform.position = this.scence2;


        }

        else if (nowScene == 3)
        {
            transform.position = this.scence3;


        }

        else if (nowScene == 4)
        {
            transform.position =this.scence4;


        }

        else if (nowScene == 5)
        {
            transform.position = this.scence5;


        }
    }
}
