#version 400

#extension GL_ARB_separate_shader_objects : enable
#extension GL_ARB_shading_language_420pack : enable

layout (location = 0) in vec2 inPos;
layout (set = 0, binding = 0) uniform AreaUB
{
    float width;
    float height;
} area;

layout (location = 0) out vec3 outColor;

void main()
{
    gl_Position = vec4(inPos.x * area.width, inPos.y * area.height, 0.0, 1.0);

    outColor = vec3(inPos, 0);
}
