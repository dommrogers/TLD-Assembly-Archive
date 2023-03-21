using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class EntityWard : MonoBehaviour
{
	public enum State
	{
		Awake,
		Done,
		Ward
	}

	[Serializable]
	public struct EntityWardSaveData
	{
		public string m_Guid;

		public State m_State;

		public float m_TimeRemaining;
	}

	[Serializable]
	public class EntityWardListContainer
	{
		public List<EntityWardSaveData> m_List;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public EntityWardListContainer()
		{
		}
	}

	public float m_TriggerRadius;

	public float m_WardRadius;

	public float m_WardDurationSeconds;

	public GameObject m_NormalCampfireObject;

	private string m_Guid;

	private State m_State;

	private float m_TimeRemaining;

	private Fire m_Fire;

	private static List<EntityWard> s_EntityWards;

	private static EntityWardListContainer s_EntityWardContainer;

	[CallerCount(Count = 0)]
	public float GetTimeRemainingPct()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "UpdateAwake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static EntityWard FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 8)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CallsUnknownMethods(Count = 4)]
	private void DisableWard()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void UpdateAwake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWard()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(EntityWard), Member = "Start")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	private void Deserialize(EntityWardSaveData data)
	{
	}

	[CallerCount(Count = 0)]
	private EntityWardSaveData Serialize()
	{
		return default(EntityWardSaveData);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EntityWard()
	{
	}
}
