using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCube : MonoBehaviour
{
    private GameObject organ;
    Vector3 originalObjectScale;
    Vector2 originalObjectPosition;
    Camera m_MainCamera;
    private bool displayOrgan = false;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.SetParent()
        gameObject.AddComponent<RectTransform>();
        organ = this.gameObject;
        m_MainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCubePos(Vector3 pos)
    {
        gameObject.transform.localPosition = pos;
        
    }

    public void UpdatePosSize(List<float> arr)
    {
        
        string text = string.Join(",", arr);
        Debug.Log(text);

        if (!arr.Contains(0F))
        {
            Vector3 avgPos = new Vector3(arr[6], (arr[1] + arr[3] + arr[5]*0.75F) / 3, 0F);
            gameObject.transform.localPosition = avgPos;
            Debug.Log(avgPos.ToString());
            //float width = arr[2] - arr[0];
            Vector3 point1 = new Vector3(arr[2], 0F, 0F);
            Vector3 point2 = new Vector3(arr[0], 0F, 0F);
            Vector3 width = Vector3.Scale((m_MainCamera.ScreenToWorldPoint(point1) - m_MainCamera.ScreenToWorldPoint(point2)),(new Vector3(0.75F,0.75F,0.75F)));
            
            Vector3 point3 = new Vector3(0F, ((arr[1] + arr[3]) / 2), 0F);
            Vector3 point4 = new Vector3(0, arr[5], 0F);
            Vector3 height = Vector3.Scale((m_MainCamera.ScreenToWorldPoint(point4) - m_MainCamera.ScreenToWorldPoint(point3)), (new Vector3(0.5F, 0.5F, 0.5F)));
            Debug.Log("width height" + width.x + " " + height.y);
            //GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
            Bounds test = getBounds();
            gameObject.transform.localScale = new Vector3((width.x / 2) * gameObject.transform.localScale.x / test.extents.x, (height.y / 2) * gameObject.transform.localScale.y / test.extents.y, gameObject.transform.localScale.z / test.extents.z);
            //Debug.Log(test.ToString());
        }

    }

    private Bounds getBounds()
    {
        //var totalBounds = new Bounds(organ.transform.position, Vector3.zero);
        /*foreach (Renderer r in organ.GetComponentsInChildren<Renderer>())
        {
            Debug.Log(r.bounds.ToString());
            totalBounds.Encapsulate(r.bounds);
        }*/
        Bounds totalBounds = organ.GetComponentInChildren<Renderer>().bounds;
        
        return totalBounds;
    }
    
}

