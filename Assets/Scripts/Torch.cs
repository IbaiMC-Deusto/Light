using UnityEngine;

public class Torch : MonoBehaviour
{

    bool isEnabled = true;

    void Update()
    {
        TorchEnable();
    }

    void TorchEnable()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            isEnabled = !isEnabled;
            this.gameObject.GetComponent<Light>().enabled = isEnabled;
        }

    }
}
