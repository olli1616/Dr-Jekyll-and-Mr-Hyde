using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public Camera cam;
    public Vector3 selectionPoint;
    private Vector2 cursorPosition;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            cursorPosition = FindMousePos();
        }
    }
    Vector2 FindMousePos()
    {
        //set up variables
        Event currentEvent = Event.current;
        Vector2 mousePosition = new Vector2();
        //get mouse position in screen space
        mousePosition.x = currentEvent.mousePosition.x;
        mousePosition.y = cam.pixelHeight - currentEvent.mousePosition.y;

        return mousePosition;

    }

}
