using UnityEngine;
using UnityEngine.Events;

public class FlipTransform : MonoBehaviour
{
    public UnityEvent flipTranform;

    private void Update()
    {
        if(Input.GetKeyDown(Keycode.Space))
        {
            FlipTForm();
        }
    }

    private void FlipTForm()
    {
        transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
        flipTranform.Invoke();
        Debug.Log("Yeehaw");
    }
}