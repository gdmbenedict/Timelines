using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewBehaviourScript : MonoBehaviour
{
    public PlayableDirector timeline;

    //function called on entering trigger volume
    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        gameObject.SetActive(false);
    }
}
