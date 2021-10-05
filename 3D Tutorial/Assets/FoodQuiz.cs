using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodQuiz : MonoBehaviour
{

    [SerializeField] Dialogue _dialogue;
    [SerializeField] Dialogue _correctChoiceDialogue;
    [SerializeField] Dialogue _incorrectChoicedialogue;
    [SerializeField] Dialogue _NPCDialogue;

    [SerializeField] GameObject _NPC;
    [SerializeField] GameObject _correctFood;
    [SerializeField] RuntimeData _runtimeData;

    public bool _done;
    
    // Start is called before the first frame update
    void Start()
    {
        _done = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        GameEvents.InvokeDialogInitiated(_dialogue);
        Destroy(gameObject.GetComponent<BoxCollider>());
    }

    public IEnumerator FoodSelected(GameObject food){
        yield return new WaitForEndOfFrame();

        if(food == _correctFood){
            GameEvents.InvokeDialogInitiated(_correctChoiceDialogue);
            Player._health += 1;
            if(Player._health > 3){
                Player._health = 3;
            }
            Destroy(food);
            _done = true;
        }
        else if(food == _NPC){
            GameEvents.InvokeDialogInitiated(_NPCDialogue);
        }
        else{
            GameEvents.InvokeDialogInitiated(_incorrectChoicedialogue);
            Player._health -= 1;
            Destroy(food);
        }
    }
}
