using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text txtNumCubes;
    public GameObject clone;

    public void MultiInstantiate()
    {
        
       for (int counter = 0;  counter < int.Parse(txtNumCubes.text); counter++)
        {
            clone = Instantiate(objectToClone);
            Destroy(clone,3);
        }
        

    }
}
