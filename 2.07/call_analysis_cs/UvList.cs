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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public Vector4 GetUvs(string texName)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	public bool HasUvs(string texName)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public UvList()
	{
	}
}
