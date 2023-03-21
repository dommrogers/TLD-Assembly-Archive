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

	[Calls(Type = typeof(LodBiasLocal), Member = "SetBias")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 75)]
	[CalledBy(Type = typeof(LodBiasLocal), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	private void SetBias()
	{
	}

	[CallerCount(Count = 0)]
	public LodBiasLocal()
	{
	}
}
