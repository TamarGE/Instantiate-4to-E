using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text cloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        
        for (int counter = 0; counter < int.Parse(cloneAmount.text); counter++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 1); //destruír el clon después de un seg
        }
        

    }
}
