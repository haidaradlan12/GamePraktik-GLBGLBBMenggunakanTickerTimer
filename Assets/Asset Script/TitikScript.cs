using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitikScript : MonoBehaviour
{
    public TMPro.TMP_Text kecepatan;
    public Slider RotateSlider; //RotateSlider.value
    public GameObject yangdiduplicate;
    public GameObject parenting;
    public GameObject[] titik;
    public GameObject[] pembagiT;
    public int banyaknya;
    int jarak = 40;
    private GameObject[] assetclone;
    int pengurangan =0;
    int posisi; 
    float posisiT;
    int a;
    double ve1, ve2, ve3;
    float s, ve, t, s1;
    int penguranganT;
    int hit1, hit2, hit3;

    [SerializeField] float currentRotation = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        posisi = 180;
    }

    // Update is called once per frame
    void Update()
    {
        //hitungan
        transform.localEulerAngles = new Vector3(0.0f, 0.0f, -(RotateSlider.value));
        if (a==1)
        {
            //titik
            jarak = jarak + pengurangan;
            hit1 = 7180 - 180;
            hit2 = hit1 / jarak;
            banyaknya = hit2;
            titik = new GameObject[banyaknya];
            posisi = (180 - 4000);

            //perhitungan jarak
            penguranganT = pengurangan / 10;
            t = 20 - penguranganT;
            s = 70;
            ve = s / t;
            s1 = ve*200;
            posisiT = (180 - 4000);

            //pemanggilan kecepatan
            ve1 = ve / 100;
            ve2 = ve1 * 2;
            ve3 = System.Math.Round(ve2,4);
            kecepatan.text = ve3.ToString();
            a = 2;
        }
        else  if (a==2)
        {
            for (int j = 0; j < banyaknya; j++)
            {
                titik[j] = GameObject.Instantiate(yangdiduplicate);
                titik[j].transform.parent = parenting.transform;
                titik[j].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                titik[j].transform.localPosition = new Vector2(0, (posisi));
                posisi = posisi + jarak;

                if ((j + 1) == banyaknya)
                {
                    a = 3;
                }
                else
                {
                    a = 2;
                }                
            }
        }
        else if (a==3)
        {
            for (int m = 0; m < 12; m++)
            {
                pembagiT[m].transform.localPosition = new Vector2(23.18f, (posisiT));
                posisiT = posisiT + s1;
                if ((m+1)==12)
                {
                    a = 0;
                }
                else
                {
                    a = 3;
                }
            }
        }
        else
        {
            pengurangan = (int)RotateSlider.value;
        }
        
    }
    private void OnGUI()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, -(currentRotation)));
    }

    public void run(int nilai)
    {
        a = nilai;
    }
    public void refresh()
    {
        a = 0;
        jarak = 40;
        kecepatan.text = "?".ToString();
        assetclone = GameObject.FindGameObjectsWithTag("CloneGLB");
        for (int k=1; k<assetclone.Length; k++)
        {
            Destroy(assetclone[k]);
        }
    }

}
