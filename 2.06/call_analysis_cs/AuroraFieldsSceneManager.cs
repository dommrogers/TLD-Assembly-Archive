using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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

		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = ".cctor")]
		[CallerCount(Count = 1)]
		public AuroraFieldsSceneManagerDataProxy()
		{
		}
	}

	public Dictionary<string, AuroraField> m_AuroraFieldsDictionary;

	public List<AuroraField> m_RegisteredAuroraFields;

	public static bool m_AllStaticFieldsEnabled;

	private static AuroraFieldsSceneManagerDataProxy m_AuroraFieldsSceneManagerDataProxy;

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetAuroraFieldByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraField), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public AuroraField GetAuroraFieldByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	public void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAuroraFields(bool active)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	public AuroraField GetFieldContaining(Vector3 position)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallerCount(Count = 0)]
	public AuroraField GetFieldContaining(Vector3 position, float radius)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public AuroraField GetClosestActiveFieldDistance(out float distanceToField, Vector3 position)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distanceToField) = null;
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableAllStaticFields(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	public AuroraField GetPlayerSafeHaven()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 11)]
	public AuroraFieldsSceneManager()
	{
	}
}
