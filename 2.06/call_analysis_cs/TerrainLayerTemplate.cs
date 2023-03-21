using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainLayerTemplate : ScriptableObject
{
	public enum TerrainType
	{
		Snow,
		Ice,
		Cave
	}

	public string m_TemplateName;

	public TerrainType m_TerrainType;

	public TerrainLayer[] m_Layers;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TerrainLayerTemplate()
	{
	}
}
