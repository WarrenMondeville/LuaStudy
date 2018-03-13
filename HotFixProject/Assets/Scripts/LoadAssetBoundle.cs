using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class LoadAssetBoundle : MonoBehaviour
{

    public string URL;
    public string assetname;
    IEnumerator Start()
    {
        // string url = Path.Combine("file://F:/MyGit/LuaStudy/HotFixProject/Assets/StreamingAssets"/*+Application.streamingAssetsPath*/, URL);
        string url = Path.Combine("file://"+Application.streamingAssetsPath.Replace("'\'", "'/'"), URL);
        Debug.Log(url);
        using (WWW www = new WWW( url))
        {
            yield return www;
            if (www.error != null)
            {
                Debug.Log("net error" + www.error);
            }
            else
            {
                AssetBundle bundle = www.assetBundle;
                var obj = bundle.LoadAsset<GameObject>(assetname);
                Instantiate<GameObject>(obj);
                bundle.Unload(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Application.streamingAssetsPath.Replace("'\'","'/'");
    }
}
