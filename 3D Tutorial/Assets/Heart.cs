using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Heart").gameObject.SetActive(true);
        transform.Find("Heart2").gameObject.SetActive(true);
        transform.Find("Heart3").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player._health >= 1){
            transform.Find("Heart").gameObject.SetActive(true);
        }
        else if(Player._health < 1){
            transform.Find("Heart").gameObject.SetActive(false);
            transform.Find("Game Over").gameObject.SetActive(true);
            transform.Find("ExitButton").gameObject.SetActive(true);
        }

        if(Player._health >= 2){
            transform.Find("Heart2").gameObject.SetActive(true);
        }
        else if(Player._health < 2){
            transform.Find("Heart2").gameObject.SetActive(false);
        }

        if(Player._health == 3){
            transform.Find("Heart3").gameObject.SetActive(true);;
        }
        else if(Player._health < 3){
            transform.Find("Heart3").gameObject.SetActive(false);
        }
    }
}
