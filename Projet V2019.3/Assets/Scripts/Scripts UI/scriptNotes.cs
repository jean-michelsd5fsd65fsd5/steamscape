using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNotes : MonoBehaviour
{
    public GameObject PanelNote;

    public GameObject TexteDeLaNote;

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
        PanelNote.SetActive(true);
        TexteDeLaNote.SetActive(true);
        ScriptPause.isPanelNoteAffiché = true;
    }


}
