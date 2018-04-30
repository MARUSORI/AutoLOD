﻿using UnityEngine;

namespace UnityEditor.Experimental.AutoLOD
{
    [CreateAssetMenu(fileName = "TextureAtlas", menuName = "AutoLOD/Texture Atlas")]
    public class TextureAtlas : ScriptableObject
    {
        public Texture2D textureAtlas;
        public Texture2D[] textures;
        public Rect[] uvs;
    }
}
