using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Scenes.ObjectReferences;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;

namespace TLD.Gameplay;

public class BunkerDistributor : ScriptableObject
{
	[Serializable]
	private class BunkerLocationInteriorPair
	{
		public readonly BunkerLocationReference m_LocationReference;

		public readonly BunkerInteriorSpecification m_ReplacementInterior;

		[CalledBy(Type = typeof(BunkerDistributor), Member = "DistributeBunkerInteriors")]
		[CalledBy(Type = typeof(BunkerDistributor), Member = "Deserialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SceneObjectReference), Member = "add_OnAvailable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BunkerLocationInteriorPair), Member = "ApplyInterior")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public BunkerLocationInteriorPair(BunkerLocationReference bunkerLocation, BunkerInteriorSpecification bunkerInterior)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Detach()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SceneObjectReference), Member = "add_OnAvailable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BunkerLocationInteriorPair), Member = "ApplyInterior")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void Attach()
		{
		}

		[CalledBy(Type = typeof(BunkerLocationInteriorPair), Member = ".ctor")]
		[CalledBy(Type = typeof(BunkerLocationInteriorPair), Member = "Attach")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 3)]
		private void ApplyInterior(SceneObjectReference reference, GameObject owner)
		{
		}
	}

	private AssetLabelReference m_BunkerLocationLabel;

	private BunkerInteriorSpecification[] m_BunkerInteriors;

	private readonly List<BunkerLocationInteriorPair> m_Replacements;

	private readonly List<BunkerLocationSaveData> m_SaveData;

	[CalledBy(Type = typeof(SandboxConfig), Member = "StartGame")]
	[CalledBy(Type = typeof(SandboxConfig), Member = "LoadGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BunkerDistributor), Member = "ClearReplacementData")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(GenericPool<>), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BunkerLocationInteriorPair), Member = ".ctor")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 47)]
	public void DistributeBunkerInteriors()
	{
	}

	[CalledBy(Type = typeof(SandboxConfig), Member = "SaveGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public List<BunkerLocationSaveData> Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SandboxConfig), Member = "LoadGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BunkerDistributor), Member = "ClearReplacementData")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BunkerLocationInteriorPair), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public void Deserialize(List<BunkerLocationSaveData> savedData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BunkerDistributor), Member = "ClearReplacementData")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BunkerDistributor), Member = "DistributeBunkerInteriors")]
	[CalledBy(Type = typeof(BunkerDistributor), Member = "Deserialize")]
	[CalledBy(Type = typeof(BunkerDistributor), Member = "OnDestroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void ClearReplacementData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private BunkerLocationReference FindBunkerLocation(IList<BunkerLocationReference> bunkerLocations, string bunkerId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private BunkerInteriorSpecification FindBunkerInterior(string interiorId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public BunkerDistributor()
	{
	}
}
