//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using GameFrameX;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.Debugger.Runtime
{
    public sealed partial class DebuggerComponent : GameFrameworkComponent
    {
        private sealed class PathInformationWindow : ScrollableDebuggerWindowBase
        {
            protected override void OnDrawScrollableWindow()
            {
                GUILayout.Label("<b>Path Information</b>");
                GUILayout.BeginVertical("box");
                {
                    DrawItem("Current Directory", PathHelper.NormalizePath(Environment.CurrentDirectory));
                    DrawItem("Data Path", PathHelper.NormalizePath(Application.dataPath));
                    DrawItem("Persistent Data Path", PathHelper.NormalizePath(Application.persistentDataPath));
                    DrawItem("Streaming Assets Path", PathHelper.NormalizePath(Application.streamingAssetsPath));
                    DrawItem("Temporary Cache Path", PathHelper.NormalizePath(Application.temporaryCachePath));
#if UNITY_2018_3_OR_NEWER
                    DrawItem("Console Log Path", PathHelper.NormalizePath(Application.consoleLogPath));
#endif
                }
                GUILayout.EndVertical();
            }
        }
    }
}
