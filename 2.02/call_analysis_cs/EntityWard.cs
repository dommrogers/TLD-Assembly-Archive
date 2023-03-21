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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetTimeRemainingPct()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 31)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "UpdateAwake")]
	[Calls(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static EntityWard FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void DisableWard()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateAwake()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateWard()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "Start")]
	[CalledBy(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntityWard), Member = "DisableWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
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
