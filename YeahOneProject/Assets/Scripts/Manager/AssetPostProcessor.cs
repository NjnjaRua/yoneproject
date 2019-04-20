using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetPostProcessor : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        Debug.Log("<color=green>OnPreprocessTexture </color>" + assetPath);
        if(assetPath.Contains("BG_"))
        {
            TextureImporter _textureImporter = (TextureImporter)assetImporter;
            _textureImporter.maxTextureSize = 2048;
        }
    }


}
