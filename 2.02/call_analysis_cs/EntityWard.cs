using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	public float GetTimeRemainingPct()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 31)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EntityWard), Member = "UpdateAwake")]
	[Calls(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 12)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	public static EntityWard FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 27)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	private void DisableWard()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void UpdateAwake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateWard()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EntityWard()
	{
	}
}
