using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizChecker : MonoBehaviour
{
    int _childCount;
    [SerializeField] FoodQuiz _quiz1;
    [SerializeField] FoodQuiz _quiz2;
    [SerializeField] FoodQuiz _quiz3;
    // Start is called before the first frame update
    void Start()
    {
        _childCount = gameObject.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        int count = 0;
        if(_quiz1._done == true){
            count++;
        }

        if(_quiz2._done == true){
            count++;
        }

        if(_quiz3._done == true){
            count++;
        }

        if(count == _childCount){
            if(SceneManager.GetActiveScene().name == "SampleScene"){
                SceneManager.LoadScene(1);
            }
        }
    }
}
