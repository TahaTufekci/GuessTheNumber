using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("you wanna play a game ? (Y/N)");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y)){
            print("Nicee! Remember a number and hit the enter");

        }
        else if(Input.GetKeyDown(KeyCode.N)){
            print("Ok... Whatever");
        }
        if(Input.GetKeyDown(KeyCode.Return)){

            
        }
        
    }
}
