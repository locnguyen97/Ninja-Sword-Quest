using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    /*[SerializeField] private GameObject real;
    [SerializeField] private GameObject fake;*/
    // Start is called before the first frame update
    private SpriteMask mask;
    void Start()
    {
        mask = GetComponent<SpriteMask>();
        mask.enabled = false;
    }

    public void Show()
    {
        mask.enabled = true;
        
    }
}
