using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDepthShader : MonoBehaviour
{
    public Material postProcessingMaterial;

    void Start()
    {
        GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
    }

    //method which is automatically called by unity after the camera is done rendering
    private void OnRenderImage(RenderTexture source, RenderTexture destination){
        Graphics.Blit(source, destination, postProcessingMaterial);
    }
}
