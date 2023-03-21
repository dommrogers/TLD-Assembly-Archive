using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class DecalVariant
{
	public string m_Name;

	public Vector3 m_RenderScale;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DecalVariant()
	{
	}
}
