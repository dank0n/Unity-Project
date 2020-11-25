using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItepPicker : MonoBehaviour
{
    [SerializeField] private int _healValue;
    [SerializeField] private int _mpValue;
    [SerializeField] private bool _triplejump;
    private void OnTriggerEnter2D(Collider2D info)
    {
        info.GetComponent<Player_Controller>().ChangeHp(_healValue);
        info.GetComponent<Player_Controller>().ChangeMP(_mpValue);
        if(info.GetComponent<Movement_Controller>()._morejumps == false)
        {   
            info.GetComponent<Movement_Controller>().MoreJumps(_triplejump);
        }
        Destroy(gameObject);
    }
}
