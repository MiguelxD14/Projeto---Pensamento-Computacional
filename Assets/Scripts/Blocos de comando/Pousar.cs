using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pousar : MonoBehaviour
{
    public GameObject Fliper;
    public bool pousa;
    Animator animator;
    public Voar Voar;
    // Start is called before the first frame update
    void Start()
    {
        animator = Fliper.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pousa == true)
        {
            Debug.Log("Teste pouso");
            Voar.voa = false;
            animator.SetBool("Pousar", true);
            // pousa = false;
        }

        if(pousa == false)
        {
            animator.SetBool("Pousar", false);
        }


    }
}
