using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionIlluminationArea : MonoBehaviour
{
	public float m_Radius;

	private static List<MissionIlluminationArea> s_RegisteredIlluminationAreas;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsInIlluminationArea(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MissionIlluminationArea()
	{
	}
}
