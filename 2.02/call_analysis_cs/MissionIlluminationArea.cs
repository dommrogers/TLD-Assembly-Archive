using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionIlluminationArea : MonoBehaviour
{
	public float m_Radius;

	private static List<MissionIlluminationArea> s_RegisteredIlluminationAreas;

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsInIlluminationArea(Vector3 pos)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionIlluminationArea()
	{
	}
}
