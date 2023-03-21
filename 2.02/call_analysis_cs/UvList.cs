using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UvList : ScriptableObject
{
	public Rect[] m_Uvs;

	public string[] m_TexNames;

	private Dictionary<string, Vector4> m_Dict;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	public Vector4 GetUvs(string texName)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	public bool HasUvs(string texName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UvList()
	{
	}
}
