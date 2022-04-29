using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleMath : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Text first_number,second_number,operation,decider,answer;
    public UnityEngine.UI.InputField input_field;
    
    int num_one,num_two,sign,result;
    void Start()
    {
        newQuestion();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkResult(){
        if(int.Parse(answer.text) == result){
             decider.text = "TRUE";
          }
        else{
            decider.text = "FALSE";
        }
 
        
    }
    public void newQuestion(){
        decider.text = "";
        input_field.text = "";
        num_one = Random.Range(1,10);
        num_two = Random.Range(1,10);
        sign = Random.Range(1,5);

        switch(sign){
           case 1:
              operation.text ="+";
              result  = num_one + num_two;
              break;
           case 2:
              operation.text ="-";
              result  = num_one - num_two;
              break;
           case 3:
              operation.text ="*";
              result  = num_one * num_two;
              break;
           case 4:
              operation.text ="/";
              if(num_two == 0){
                  newQuestion();
              }
              result  = num_one / num_two;    // DIVISIONNNN CHECK!!!!!!!!!!!!
              break;   
        }
        first_number.text = num_one + "";
        second_number.text = num_two + "";
        

    }

}
