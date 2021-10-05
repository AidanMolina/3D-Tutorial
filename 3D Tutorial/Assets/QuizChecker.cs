using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizChecker : MonoBehaviour
{
    public static int _childCount;
    [SerializeField] FoodQuiz _quiz1;
    [SerializeField] FoodQuiz _quiz2;
    [SerializeField] FoodQuiz _quiz3;

    [SerializeField] GameObject _canvas;
    [SerializeField] RuntimeData _runtimeData;
    public static int count;

    // Start is called before the first frame update
    void Start()
    {
        _childCount = gameObject.transform.childCount;
        count = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(_quiz1._done == true){
            count++;
            _quiz1._done = false;
        }

        if(_quiz2._done == true){
            count++;
            _quiz2._done = false;
        }

        if(_quiz3._done == true){
            count++;
            _quiz3._done = false;
        }

        if(count == _childCount){
            if(SceneManager.GetActiveScene().name == "SampleScene"){
                _canvas.transform.Find("NextLevelButton").gameObject.SetActive(true);
                _runtimeData.CurrentGameplayState = GameplayState.InDialog;
                Cursor.lockState = CursorLockMode.None;
            }
            if(SceneManager.GetActiveScene().name == "SceneTwo"){
                _canvas.transform.Find("You Win").gameObject.SetActive(true);
                _canvas.transform.Find("ExitButton").gameObject.SetActive(true);
                _runtimeData.CurrentGameplayState = GameplayState.InDialog;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
