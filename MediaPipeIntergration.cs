using UnityEngine;
using System.Runtime.InteropServices;

public class MediaPipeIntegration : MonoBehaviour
{
    [DllImport("MediaPipePlugin")]
    private static extern Status RunMediaPipe();


    void Start()
    {
        Status status = RunMediaPipe();
        Debug.Log("Status: " + status);
    }
}
