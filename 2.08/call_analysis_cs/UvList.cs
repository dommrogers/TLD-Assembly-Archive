using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UvList : ScriptableObject
{
	public Rect[] m_Uvs;

	public string[] m_TexNames;

	private Dictionary<string, Vector4> m_Dict;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Vector4 GetUvs(string texName)
	{
		return default(Vector4);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasUvs(string texName)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public UvList()
	{
	}
}
