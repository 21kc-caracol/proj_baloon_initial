Shader "Unlit/DepthShader"
{
    // Properties
    // {
    //     _DepthScale ("Depth Scaling factor", Range(0.0,10.0)) = 1.0
    // }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #include "UnityCG.cginc"

            #pragma vertex vert
            #pragma fragment frag

            sampler2D _CameraDepthTexture;

            struct appdata{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

            struct v2f
            {
                float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float depth = 1 - Linear01Depth(tex2D(_CameraDepthTexture, i.uv).r);
                
                return depth;
            }
            ENDCG
        }
    }
}
