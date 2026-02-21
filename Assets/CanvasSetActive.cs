using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanvasSetActive : MonoBehaviour
{
    public GameObject GameCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameCanvas.SetActive(true);
        }
    }
}
