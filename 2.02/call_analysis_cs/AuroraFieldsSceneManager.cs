using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraFieldsSceneManager
{
	public class AuroraFieldsSceneManagerDataProxy
	{
		public struct FieldContainerSerialized
		{
			public string m_Name;

			public string m_Guid;

			public string m_AuroraFieldSerialized;
		}

		public List<FieldContainerSerialized> m_SerializedFields;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = ".cctor")]
		[CallsUnknownMethods(Count = 12)]
		public AuroraFieldsSceneManagerDataProxy()
		{
		}
	}

	public Dictionary<string, AuroraField> m_AuroraFieldsDictionary;

	public List<AuroraField> m_RegisteredAuroraFields;

	public static bool m_AllStaticFieldsEnabled;

	private static AuroraFieldsSceneManagerDataProxy m_AuroraFieldsSceneManagerDataProxy;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 23)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AuroraField), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetAuroraFieldByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 6)]
	public AuroraField GetAuroraFieldByName(string name)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallsUnknownMethods(Count = 8)]
	public void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UpdateAuroraFields(bool active)
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	public AuroraField GetFieldContaining(Vector3 position)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AuroraField GetFieldContaining(Vector3 position, float radius)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 4)]
	public AuroraField GetClosestActiveFieldDistance(out float distanceToField, Vector3 position)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distanceToField) = null;
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableAllStaticFields(bool enabled)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsUnknownMethods(Count = 5)]
	public AuroraField GetPlayerSafeHaven()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraManager), Member = ".cctor")]
	public AuroraFieldsSceneManager()
	{
	}
}
