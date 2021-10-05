using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodQuiz : MonoBehaviour
{

    [SerializeField] Dialogue _dialogue;
    [SerializeField] Dialogue _correctChoiceDialogue;
    [SerializeField] Dialogue _incorrectChoicedialogue;

    [SerializeField] GameObject _correctFood;
    [SerializeField] RuntimeData _runtimeData;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        GameEvents.InvokeDialogInitiated(_dialogue);
    }

    public IEnumerator FoodSelected(GameObject food){
        yield return new WaitForEndOfFrame();

        if(food == _correctFood){
            GameEvents.InvokeDialogInitiated(_correctChoiceDialogue);
            Player._health += 1;
            if(Player._health > 3){
                Player._health = 3;
            }
        }
        else{
            GameEvents.InvokeDialogInitiated(_incorrectChoicedialogue);
            Player._health -= 1;
        }
        
        Destroy(food);
    }
}
