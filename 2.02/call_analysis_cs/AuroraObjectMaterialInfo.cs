using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AuroraObjectMaterialInfo
{
	public Renderer m_Renderer;

	public Material m_AuroraMaterial;

	public Material m_NormalMaterial;

	private Material m_OriginalMaterial;

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	public void SetOriginalMaterial(Material mat)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Material GetOriginalMaterial()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AuroraObjectMaterialInfo()
	{
	}
}
