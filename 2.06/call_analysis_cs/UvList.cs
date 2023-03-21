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
	[CallsUnknownMethods(Count = 7)]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	public Vector4 GetUvs(string texName)
	{
		return default(Vector4);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	public bool HasUvs(string texName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public UvList()
	{
	}
}
