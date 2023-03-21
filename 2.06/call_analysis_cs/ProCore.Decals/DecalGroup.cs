using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ProCore.Decals;

[Serializable]
public class DecalGroup
{
	public const int MAX_ATLAS_SIZE_DEFAULT = 4096;

	public const int ATLAS_PADDING_DEFAULT = 4;

	public List<Decal> decals;

	public string name;

	public Shader shader;

	public bool isPacked;

	public Material material;

	public Material fullscreenDecalMaterial;

	public int maxAtlasSize;

	public int padding;

	[CallerCount(Count = 0)]
	public DecalGroup(string name, List<Decal> decals, bool isPacked, Shader shader, Material material, int maxAtlasSize, int padding, Material fullscreenDecalMaterial)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool ContainsTexture(Texture2D tex)
	{
		return default(bool);
	}
}
