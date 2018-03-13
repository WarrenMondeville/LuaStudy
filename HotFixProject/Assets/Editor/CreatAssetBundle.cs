

using UnityEditor;

public class CreateAssetBundle {

    [MenuItem("Assets/Build/AssetBundles")]
    static int BuildAllAssetsBundles()
    {

        BuildPipeline.BuildAssetBundles("Assets/StreamingAssets/ABs", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        return 0;
    }
}
