using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionIlluminationArea : MonoBehaviour
{
	public float m_Radius;

	private static List<MissionIlluminationArea> s_RegisteredIlluminationAreas;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionIlluminationArea()
	{
	}
}
