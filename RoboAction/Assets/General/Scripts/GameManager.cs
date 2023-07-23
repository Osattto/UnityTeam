using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GameManager : MonoBehaviour
{
    public static GameManager i;

   
    private void Awake()
    {
        if (i==null)
        {
            i = this;
        }
        else
        {
            Destroy(i);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
