using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodLabel : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = _runtimeData.CurrentFoodMousedOver;
    }
}
