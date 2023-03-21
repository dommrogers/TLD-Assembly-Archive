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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public AuroraFieldsSceneManagerDataProxy()
		{
		}
	}

	public Dictionary<string, AuroraField> m_AuroraFieldsDictionary;

	public List<AuroraField> m_RegisteredAuroraFields;

	public static bool m_AllStaticFieldsEnabled;

	private static AuroraFieldsSceneManagerDataProxy m_AuroraFieldsSceneManagerDataProxy;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 14)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetAuroraFieldByName")]
	[Calls(Type = typeof(AuroraField), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAuroraFields(bool active)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	public AuroraField GetFieldContaining(Vector3 position)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public AuroraField GetFieldContaining(Vector3 position, float radius)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public AuroraField GetClosestActiveFieldDistance(out float distanceToField, Vector3 position)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distanceToField) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	public void EnableAllStaticFields(bool enabled)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsUnknownMethods(Count = 3)]
	public AuroraField GetPlayerSafeHaven()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AuroraFieldsSceneManager()
	{
	}
}
