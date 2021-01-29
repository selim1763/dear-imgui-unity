﻿using UnityEngine;

namespace ImGuiNET.Unity
{
    /// <summary>
    /// Platform bindings for ImGui in Unity in charge of: mouse/keyboard/gamepad inputs, cursor shape, timing, windowing.
    /// </summary>
    public interface IImGuiPlatform
    {
        bool Initialize(ImGuiIOPtr io);
        void Shutdown(ImGuiIOPtr io);
        void PrepareFrame(ImGuiIOPtr io, Rect displayRect);

        void SetCameraAndScrollCollider(Camera camera, BoxCollider scrollCollider);
    }
}
