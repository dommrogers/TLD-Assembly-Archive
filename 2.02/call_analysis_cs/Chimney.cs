using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Chimney : MonoBehaviour
{
	public SmokeTrail m_SmokeTrail;

	public float m_LifetimeGameMinutes;

	public bool m_RestoredFromGlobalData;

	private bool m_StartHasBeenCalled;

	private static List<Chimney> m_Chimneys;

	private static ChimneySaveData m_ChimneySaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SmokeTrail), Member = "SetAlpha")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Chimney), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Chimney), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Chimney), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Chimney), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Chimney), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static Chimney GetClosestChimney(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(Chimney), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Chimney FindByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Chimney()
	{
	}
}
