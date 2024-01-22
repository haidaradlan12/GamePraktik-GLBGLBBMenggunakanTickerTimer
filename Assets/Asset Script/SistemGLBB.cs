using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemGLBB : MonoBehaviour
{
    public Slider RotateSlider;
    public GameObject titik;

    [SerializeField] float currentRotation = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, 0.0f, -(RotateSlider.value));
        //titik.transform.localPosition = new Vector2(100,)
    }

    private void OnGUI()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, -(currentRotation)));
    }

    public void AdjustAngle(float newAngle)
    {

    }
}
