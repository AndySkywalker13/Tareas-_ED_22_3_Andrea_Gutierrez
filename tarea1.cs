using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text="Harry Potter";
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            texto.text="RIDDIKULUS";
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text="ACCIO";
        }
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            texto.text="ALOHOMORA";
        }
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            texto.text="EXPECTO PATRONUM";
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            texto.text="EXPELLIARMUS";
        }
    }
}