using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class HarvestFish : HarvestBase
{
	private AssetReferenceGearItem m_BaitReference;

	private float m_BaitPerKG;

	private GearItem m_GearItem;

	private AsyncOperationHandle<GameObject> m_BaitHandle;

	private GearItem m_BaitPrefab;

	public override int YieldCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	public override GearItem GetPrefab(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 2)]
	public override int GetAmount(int index)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HarvestFish()
	{
	}
}
