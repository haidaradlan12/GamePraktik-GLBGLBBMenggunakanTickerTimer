using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitikScriptGLBB : MonoBehaviour
{
    public GameObject yangdiduplicate;
    public GameObject parenting;
    public GameObject[] titik;
    public GameObject[] pembagiT;
    private int[] stt;
    public int banyaknya;
    int jarak = 40;
    private GameObject[] assetclone;
    int posisi;

    float posisiT;
    int a;
    int hit1, hit2, hit3;
    int bebanbalok, bebannyabal;

    
    // Start is called before the first frame update
    void Start()
    {
        posisi = 180;
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            //titik
            jarak = jarak + bebannyabal;
            hit1 = 7200 - 180;
            hit2 = hit1 / jarak;
            banyaknya = hit2;
            titik = new GameObject[banyaknya];
            posisi = (180 - 4000);

            a = 2;
        }
        else if (a == 2)
        {
            for (int j = 0; j < banyaknya; j++)
            {
                titik[j] = GameObject.Instantiate(yangdiduplicate);
                titik[j].transform.parent = parenting.transform;
                titik[j].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                titik[j].transform.localPosition = new Vector2(0, (posisi));
                posisi = posisi + jarak + (bebannyabal * j);

                if ((j + 1) == banyaknya)
                {
                    a = 0;
                }
                else
                {
                    a = 2;
                }
            }
        }
        else
        {
            if (bebanbalok == 1)
            {
                bebannyabal = 2;
            }
            else if (bebanbalok == 2)
            {
                bebannyabal = 4;
            }
            else if (bebanbalok == 3)
            {
                bebannyabal = 6;
            }
            else if (bebanbalok == 4)
            {
                bebannyabal = 8;
            }
        }

    }
    private void OnGUI()
    {
        
    }

    public void run(int nilai)
    {
        a = nilai;
    }
    public void refresh()
    {
        bebanbalok = 0;
        bebannyabal = 0;
        a = 0;
        jarak = 40;
        assetclone = GameObject.FindGameObjectsWithTag("CloneGLBB");
        for (int k = 1; k < assetclone.Length; k++)
        {
            Destroy(assetclone[k]);
        }
    }
    public void beban(int nilainya)
    {
        bebanbalok = nilainya;
    }
}
