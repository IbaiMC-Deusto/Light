using UnityEngine;

public class FlickerLight : MonoBehaviour
{

    bool hasChange = false;
    [SerializeField] float lowRange;
    [SerializeField] float highRange;


    void FixedUpdate()
    {
        if (hasChange)
        {
            hasChange = false;
            return;
        }

        this.gameObject.GetComponent<Light>().intensity = Random.Range(lowRange, highRange);
        hasChange = true;
    }
}
