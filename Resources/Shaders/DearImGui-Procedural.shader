Shader "DearImGui/Procedural"
{
    // shader for builtin rendering
    SubShader
    {
        Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" }
        LOD 100

        Lighting Off
        Cull Off ZWrite On ZTest Always
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            Name "DEARIMGUI PROCEDURAL BUILTIN"

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment ImGuiPassFrag
            #include "Packages/com.armiidev.dear-imgui/Resources/Shaders/PassesBuiltin.hlsl"

            StructuredBuffer<ImVert> _Vertices;
            int _BaseVertex;

            Varyings vert(uint id : SV_VertexID)
            {

                id += _BaseVertex;
                ImVert v = _Vertices[id];
                return ImGuiPassVertex(v);
            }
            ENDCG
        }
    }
}
