using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

public class WeightReductionBuff : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GearItem> _003C_003E9__15_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
		[CallsUnknownMethods(Count = 3)]
		internal int _003CGetTargetsByWeight_003Eb__15_0(GearItem a, GearItem b)
		{
			return 0;
		}
	}

	private AssetReferenceT<GearItemData>[] m_Targets;

	private int m_AffectedItems;

	private float m_WeightReduction;

	private List<GearItemData> m_ValidTargets;

	private float m_CachedWeightReduction;

	private AsyncOperationHandle<IList<GearItemData>> m_OperationHandle;

	private GearItem m_GearItem;

	private bool m_IsDirty;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "add_m_OnInventoryItemAdded")]
	[Calls(Type = typeof(Inventory), Member = "add_m_OnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Inventory), Member = "remove_m_OnInventoryItemAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private void HandleOnInventoryChanged(GearItem _)
	{
	}

	[CalledBy(Type = typeof(WeightReductionBuff), Member = "GetWeightReduction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeTargets()
	{
	}

	[CalledBy(Type = typeof(WeightReductionBuff), Member = "GetWeightReduction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeightReductionBuff), Member = "IsActive")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "InitializeTargets")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "GetTargetsByWeight")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetWeightReduction()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "GetTargetsByWeight")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateWeightReduction()
	{
	}

	[CalledBy(Type = typeof(WeightReductionBuff), Member = "GetWeightReduction")]
	[CalledBy(Type = typeof(WeightReductionBuff), Member = "CalculateWeightReduction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void GetTargetsByWeight(List<GearItem> targets)
	{
	}

	[CallerCount(Count = 0)]
	public WeightReductionBuff()
	{
	}
}
