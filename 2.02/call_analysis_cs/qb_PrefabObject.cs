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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 7)]
	public void TryGetAssetPreview()
	{
	}
}
