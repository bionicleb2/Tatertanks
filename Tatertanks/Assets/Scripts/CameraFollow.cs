﻿
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    protected Transform _XForm_Camera;
    protected Transform _XForm_Parent;

    protected Vector3 _LocalRotation;
    protected float _CameraDistance = 10f;

    public float MouseSensitivity = 4f;
    public float ScrollSensitivity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    public bool CameraDisabled = false;


    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) ;
        {
            CameraDisabled = !CameraDisabled;
        }
        if (!CameraDisabled)
        {
            //Rotation of camera based on mouse coordinates
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) ;
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                _LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;

                //clamp the y rotation to horizon so it won't flip over at top
                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, 0f, 90f);
            }

            //zooming input from mouse wheel
            if (Input.GetAxis("Mouse Scrollwheel") != 0f)
            {
                float ScrollAmount = Input.GetAxis("Mouse Scrollwheel") * ScrollSensitivity;

                //makes camera zoom faster the further away it gets from target
                ScrollAmount *= (this._CameraDistance * 0.3f);

                this._CameraDistance += ScrollAmount * -1f;

                this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 100f);
            }
        }
        //Actual camera rig transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitDampening);

        if(this._XForm_Camera.localPosition.z != this._CameraDistance * -1f)
        {
            this._XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this._XForm_Camera.localPosition.z, this._CameraDistance * -1f, Time.deltaTime * ScrollDampening));
        }
    }
}
