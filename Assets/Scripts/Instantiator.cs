using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject objectToClone;

    public void CloneObject()
    {
        int a =  1;
        while (a < 4)
        {
            Instantiate(objectToClone);
            a++;
        }
        
    }
}
