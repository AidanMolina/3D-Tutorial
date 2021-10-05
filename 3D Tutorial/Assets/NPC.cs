using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;

    [SerializeField] GameObject _parentQuiz;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter(){
        transform.Find("Spot Light").gameObject.SetActive(true);
        _runtimeData.CurrentFoodMousedOver = name;
    }

    void OnMouseExit(){
        transform.Find("Spot Light").gameObject.SetActive(false);
        _runtimeData.CurrentFoodMousedOver = "";
    }

    void OnMouseDown(){
        if(_runtimeData.CurrentGameplayState == GameplayState.FreeWalk){
            StartCoroutine(_parentQuiz.GetComponent<FoodQuiz>().FoodSelected(gameObject));
            _runtimeData.CurrentFoodMousedOver = "";
        }
    }
}
