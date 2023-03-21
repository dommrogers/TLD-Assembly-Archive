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
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsUnknownMethods(Count = 8)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public QualityLevelFilter()
	{
	}
}
