using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using UnityEngine;

namespace TLD.Gameplay;

public class CustomSpawnedItemChild : MonoBehaviour
{
	private string m_LocalGuid;

	private string _003CGuid_003Ek__BackingField;

	public string Guid
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 57)]
		private set
		{
		}
	}

	public string LocalGuid
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "InitializeSpawnedItem")]
	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetGuid(string guid)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomSpawnedItemChild()
	{
	}
}
