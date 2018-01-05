using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamesAndPurchases : MonoBehaviour {

    public string TeamLeader;
    public string Person1;
    public string Person2;
    public string Person3;
    public string Person4;
    

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void AcceptStringInput(string userInput)
    {
        
    }
    
}
