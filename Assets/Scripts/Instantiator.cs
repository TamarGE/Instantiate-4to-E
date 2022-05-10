using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text cloneAmount;

    public void MultiInstantiate()
    {
        int counter = 0;
        while (counter < int.Parse(cloneAmount.text))
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
