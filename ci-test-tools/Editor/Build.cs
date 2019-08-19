﻿using UnityEditor;
using UnityEngine;

public class Build : MonoBehaviour
{
    static void Execute ()
    {
        BuildPipeline.BuildPlayer (new [] {"Assets/Scenes/SampleScene.unity"}, Application.dataPath.Replace("Assets", "Build/") +  EditorUserBuildSettings.activeBuildTarget, EditorUserBuildSettings.activeBuildTarget, BuildOptions.None);
    }
}
