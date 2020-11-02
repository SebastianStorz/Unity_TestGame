using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameObject nextLevel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            nextLevel.SetActive(true);
        }
    }
}
