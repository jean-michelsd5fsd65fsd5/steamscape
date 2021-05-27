using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCle : MonoBehaviour
{
    public static bool IsCléRécupéré;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        IsCléRécupéré = true;
    }
}
