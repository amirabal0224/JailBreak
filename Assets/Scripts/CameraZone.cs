using UnityEngine;

public class CameraZone : MonoBehaviour
{
    public Camera myCamera; // Drag your camera into this in the Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchToThisCamera();
        }
    }

    void SwitchToThisCamera()
    {
        foreach (Camera cam in Camera.allCameras)
        {
            cam.enabled = false;

            AudioListener listener = cam.GetComponent<AudioListener>();
            if (listener != null)
                listener.enabled = false;
        }

        myCamera.enabled = true;

        AudioListener myListener = myCamera.GetComponent<AudioListener>();
        if (myListener != null)
            myListener.enabled = true;
    }

}
