using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class QualityLevelFilter : MonoBehaviour
{
	public enum GraphicsQuality
	{
		Low,
		Medium,
		High,
		Ultra,
		XboxOne
	}

	public GraphicsQuality m_MinimumQualityLevel;

	private Quality m_MinQualityLevel;

	private bool m_Enabled;

	private List<GameObject> m_Children;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsUnknownMethods(Count = 8)]
	public void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool PassesFilter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private Quality GetQualityLevelFromLegacyQuality(GraphicsQuality legacyQualityLevel)
	{
		return default(Quality);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public QualityLevelFilter()
	{
	}
}
