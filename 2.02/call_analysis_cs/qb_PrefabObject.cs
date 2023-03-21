using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class qb_PrefabObject
{
	public UnityEngine.Object prefab;

	public Texture2D previewTexture;

	public float weight;

	public Texture2D PreviewTexture
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public qb_PrefabObject(UnityEngine.Object prefab)
	{
	}

	[CallerCount(Count = 0)]
	public qb_PrefabObject(UnityEngine.Object prefab, float weight)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void TryGetAssetPreview()
	{
	}
}
