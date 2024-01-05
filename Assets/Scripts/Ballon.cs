using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{

    [SerializeField]
    int clicksToPop;

    void OnMouseDown()
    {
        clicksToPop--;

        transform.localScale += new Vector3(.2f, .2f, .2f);
        
        if (clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
