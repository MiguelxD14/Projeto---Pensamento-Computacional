using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour 
{
    public GameObject Trix;
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Anda") 
        {
          
             Debug.Log("� possivel se mover");
             Trix.GetComponent<botControl>().enabled = true;
            
        }
            
        
        if(collision.gameObject.tag != "Anda")
        {
             Debug.Log("N�o � possivel se mover");
            Trix.GetComponent<botControl>().enabled = false;
            
        }

    }

}

