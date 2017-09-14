using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
public class ResetCameraPos : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
      //  VRSettings.enabled = true;
        Valve.VR.OpenVR.System.ResetSeatedZeroPose();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Valve.VR.OpenVR.System.ResetSeatedZeroPose();
            Valve.VR.OpenVR.Compositor.SetTrackingSpace(
  Valve.VR.ETrackingUniverseOrigin.TrackingUniverseSeated);
        }
    }
}
