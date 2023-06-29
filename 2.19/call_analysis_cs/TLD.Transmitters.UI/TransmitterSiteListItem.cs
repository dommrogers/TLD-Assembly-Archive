using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Transmitters.UI;

public class TransmitterSiteListItem : MonoBehaviour
{
	private UITexture m_RegionTexture;

	private UILabel m_TransmitterName;

	private UILabel m_TransmitterDescription;

	private UILabel m_UndiscoveredLabel;

	private UILabel m_NeedsRepairLabel;

	private TransmitterData _003CData_003Ek__BackingField;

	private AsyncOperationHandle<Texture2D> m_textureLoadOperation;

	public TransmitterData Data
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 70)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "SetupTransmitterSites")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void SetTransmitter(TransmitterData transmitter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "get_IsActive")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int Compare(TransmitterSiteListItem xItem, TransmitterSiteListItem yItem)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnRegionTextureLoaded(AsyncOperationHandle<Texture2D> op)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TransmitterSiteListItem()
	{
	}
}
