using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionIlluminationArea : MonoBehaviour
{
	public float m_Radius;

	private static List<MissionIlluminationArea> s_RegisteredIlluminationAreas;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionIlluminationArea()
	{
	}
}
