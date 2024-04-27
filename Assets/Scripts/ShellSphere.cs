using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSphere : MonoBehaviour
{
    GameObject shell;
    public int repeat = 5;
    public float Scale=0.01f;
    // Start is called before the first frame update
    void Start()
    {
        shell = gameObject;
        for (int i = 0; i < repeat; i++)
        {
           GameObject creation= Instantiate(shell, transform.position, transform.rotation,transform.parent);
            creation.transform.localScale = transform.localScale + new Vector3((Scale * i), (Scale * i), (Scale * i)) ;
            creation.GetComponent<ShellSphere>().enabled = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
