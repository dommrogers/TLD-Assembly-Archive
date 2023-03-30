using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

public class BeachcombingBigItemLocation : MonoBehaviour
{
	private List<AssetReferenceCustomSpawnedItem> m_AllowedObjects;

	private string _003CGuid_003Ek__BackingField;

	private CustomSpawnedItem _003CChild_003Ek__BackingField;

	public string Guid
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		private set
		{
		}
	}

	public CustomSpawnedItem Child
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(BeachcombingBigItemTableData), Member = "ShouldFilterOutForLocation")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DeserializeBigItems")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public bool IsReferenceAllowed(AssetReference assetReference)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BeachcombingBigItemLocation()
	{
	}
}
