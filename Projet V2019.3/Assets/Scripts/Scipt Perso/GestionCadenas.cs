using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCadenas : MonoBehaviour
{
    public Transform Porte;
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
        Debug.Log("clic rectangle");
        if (GestionCle.IsCléRécupéré)
        {
            this.gameObject.SetActive(false);
            //Porte.position = Porte.position +  new Vector3(0.00478f, 0f, 0f);
            Porte.Rotate(Vector3.up * -90);
        }
    }

}
