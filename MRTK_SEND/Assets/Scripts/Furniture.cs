using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.Azure.SpatialAnchors.Unity.Examples;
using UnityEngine.UI;

public class Furniture : MonoBehaviour
{
    [SerializeField] private Text textHolo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpatialAnchorObject()
    {
        GameObject AzureSpatialAnchors = GameObject.Find("AzureSpatialAnchors");
        AzureSpatialAnchors.GetComponent<AzureSpatialAnchorsBasicDemoScript>().anchoredObjectPrefab = gameObject;
        textHolo.text = gameObject.name;
        Debug.LogError("Spatial Anchor Object was SET to:");
        Debug.LogError(AzureSpatialAnchors.GetComponent<AzureSpatialAnchorsBasicDemoScript>().anchoredObjectPrefab.name);
    }
}
