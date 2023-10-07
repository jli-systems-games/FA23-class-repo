using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DDR : MonoBehaviour
{
    //naming it Pad instead of something like "reference" or "self" so that you can type DDR.Pad.OnUp which looks nice
    public static DDR Pad;

    private void Awake()
    {
        Pad = this;
    }

    //Up
    private bool _up;
    public bool Up { get {return _up;}}
    public void SetUp(InputAction.CallbackContext context)
    {
        if (context.started)
            _up = true;
        if (context.canceled)
            _up = false;
    }

    //Down
    private bool _down;
    public bool Down { get {return _down;}}
    public void SetDown(InputAction.CallbackContext context)
    {
        if (context.started)
            _down = true;
        if (context.canceled)
            _down = false;
    }

    //Left
    private bool _left;
    public bool Left { get {return _left;}}
    public void SetLeft(InputAction.CallbackContext context)
    {
        if (context.started)
            _left = true;
        if (context.canceled)
            _left = false;
    }

    //Right
    private bool _right;
    public bool Right { get {return _right;}}
    public void SetRight(InputAction.CallbackContext context)
    {
        if (context.started)
            _right = true;
        if (context.canceled)
            _right = false;
    }

    //Center
    private bool _center;
    public bool Center { get {return _center;}}
    public void SetCenter(InputAction.CallbackContext context)
    {
        if (context.started)
            _center = true;
        if (context.canceled)
            _center = false;
    }

    //Cross
    private bool _cross;
    public bool Cross { get {return _cross;}}
    public void SetCross(InputAction.CallbackContext context)
    {
        if (context.started)
            _cross = true;
        if (context.canceled)
            _cross = false;
    }

    //Circle
    private bool _circle;
    public bool Circle { get {return _circle;}}
    public void SetCircle(InputAction.CallbackContext context)
    {
        if (context.started)
            _circle = true;
        if (context.canceled)
            _circle = false;
    }

    //Triangle
    private bool _triangle;
    public bool Triangle { get {return _triangle;}}
    public void SetTriangle(InputAction.CallbackContext context)
    {
        if (context.started)
            _triangle = true;
        if (context.canceled)
            _triangle = false;
    }

    //Square
    private bool _square;
    public bool Square { get {return _square;}}
    public void SetSquare(InputAction.CallbackContext context)
    {
        if (context.started)
            _square = true;
        if (context.canceled)
            _square = false;
    }

    //Start
    private bool _start;
    public bool Start { get {return _start;}}
    public void SetStart(InputAction.CallbackContext context)
    {
        if (context.started)
            _start = true;
        if (context.canceled)
            _start = false;
    }

    //Select
    private bool _select;
    public bool Select { get {return _select;}}
    public void SetSelect(InputAction.CallbackContext context)
    {
        if (context.started)
            _select = true;
        if (context.canceled)
            _select = false;
    }
}
