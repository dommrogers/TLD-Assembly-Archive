using System;
using System.Collections.Generic;
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

		[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = ".cctor")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public AuroraFieldsSceneManagerDataProxy()
		{
		}
	}

	public Dictionary<string, AuroraField> m_AuroraFieldsDictionary;

	public List<AuroraField> m_RegisteredAuroraFields;

	public static bool m_AllStaticFieldsEnabled;

	private static AuroraFieldsSceneManagerDataProxy m_AuroraFieldsSceneManagerDataProxy;

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetAuroraFieldByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(AuroraField), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public AuroraField GetAuroraFieldByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAuroraFields(bool active)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public AuroraField GetFieldContaining(Vector3 position)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public AuroraField GetFieldContaining(Vector3 position, float radius)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public AuroraField GetClosestActiveFieldDistance(out float distanceToField, Vector3 position)
	{
		distanceToField = default(float);
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableAllStaticFields(bool enabled)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public AuroraField GetPlayerSafeHaven()
	{
		return null;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public AuroraFieldsSceneManager()
	{
	}
}
