using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LodBiasLocal : MonoBehaviour
{
	[Serializable]
	public struct SceneDefinition
	{
		public List<string> m_ScenesList;

		public float m_LodMultiplier;
	}

	public enum QualityLimits
	{
		All,
		Desktops,
		Consoles
	}

	public QualityLimits m_QualityLimits;

	public float m_LodMultiplier;

	public string[] m_Scenes;

	public List<SceneDefinition> m_SceneDefs;

	public bool m_CullingOnly;

	private LODGroup m_LodGroup;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LodBiasLocal), Member = "SetBias")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(LodBiasLocal), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 36)]
	private void SetBias()
	{
	}

	[CallerCount(Count = 0)]
	public LodBiasLocal()
	{
	}
}
