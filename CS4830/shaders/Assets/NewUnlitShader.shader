Shader "Tutorial/Basic"
{
    Properties
    {
        _Color("Main Color", color) = (1,0.5,0.5,1)
    }
    SubShader
    {
        Pass
        {
            Material
            {
                Diffuse [_Color]
            }
            Lighting On
        }
    }
}
// This simple shader demonstrates one of the most basic shaders possible. 
// It defines a color property called Main Color and assigns it a default 
// pink color (red=100% green=50% blue=50% alpha=100%). It then renders the object by 
// invoking a Pass and in that pass setting the diffuse material component to the 
// property _Color and turning on per-vertex lighting.