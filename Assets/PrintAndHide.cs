using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            Destroy(gameObject);
        }

        if(gameObject.tag == "Blue" && i == Random.Range(150,250))
        {
            rend.enabled = false;
        }
    }
}
