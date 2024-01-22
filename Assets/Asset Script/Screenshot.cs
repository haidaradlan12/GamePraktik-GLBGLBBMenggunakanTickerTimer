using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Screenshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        Texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/Screenshot.png", bytes);

        Destroy(texture);
    }
    public void TakeScreenshot()
    {
        StartCoroutine("Screenshot");
    }*/
}
