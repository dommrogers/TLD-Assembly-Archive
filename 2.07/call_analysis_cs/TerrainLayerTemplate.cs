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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TerrainLayerTemplate()
	{
	}
}
