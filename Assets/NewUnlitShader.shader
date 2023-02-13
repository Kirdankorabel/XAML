Shader "Unlit/NewUnlitShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    _OutlineColor("Outline Color", Color) = (1,1,1,1)
        _OutlineWidth("Outline Width", Range(0, 10)) = 1
    }
    SubShader
    { 
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
        LOD 100

        Blend ScrAlpha OneMinusSrcAlpha
        Cull Off

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                fixed4 color : COLOR;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                fixed4 color : COLOR;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            fixed4 _OutlineColor;
            float _OutlineWidth;
            
            static float2 _dirs[4] {float2(1, 0), float2(-1, 0) , float2(0, 1) ,float2(0, -1) }

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.color = v.color;
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            float GetMaxAlpha(float2 uv)
            {
                float result = 0;
                for (uint i = 0; i < 4; i++)
                {
                    float sUV = uv + _dirs[i] * _OutlineWidth;
                    result = max(result, tex2D(_MainTax, i.uv));
                }
                return result;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                col *= i.color;

                col.rgb = lerp(_outlineColor, col.rgb, col.a);
                col.a = GetMaxAlpha(i.uv);
                return col;
            }
            ENDCG
        }
    }
}
