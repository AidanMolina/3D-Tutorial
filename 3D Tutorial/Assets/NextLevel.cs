using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject _canvas;
    [SerializeField] Dialogue _startingDialogue;

    public void OnButtonPressed(){
        Player.transform.position = new Vector3(0f, 2f, -205.49f);
        _canvas.transform.Find("NextLevelButton").gameObject.SetActive(false);
        GameEvents.InvokeDialogInitiated(_startingDialogue);
    }
}
