using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.AddressableAssets;
using TLD.Events;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Transmitters.UI;

public class TransmitterSiteUIController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public TransmitterData transmitter;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
		[Calls(Type = typeof(TransmitterSiteMapItem), Member = "SetTransmitter")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CMaybeSetupTransmitterMapItem_003Eb__0(AsyncOperationHandle<GameObject> op)
		{
		}
	}

	private sealed class _003CResetSliderWhenAvailable_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransmitterSiteUIController _003C_003E4__this;

		public int numberOfSteps;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CResetSliderWhenAvailable_003Ed__35(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private WorldMapChangedEvent m_WorldMapChanged;

	private GameObject m_ListParent;

	private GameObject m_ListScrollbar;

	private GameObject m_MapsParent;

	private TransmitterSiteListItem m_ListItemPrefab;

	private UIGrid m_ListGrid;

	private UIPanel m_ListPanel;

	private UIScrollView m_ListScroll;

	private UISlider m_ListSlider;

	private int m_LastListIndex;

	private ObjectPool<TransmitterSiteListItem> m_ListItemPool;

	private readonly List<TransmitterSiteListItem> m_ActiveListItems;

	private readonly List<TransmitterSiteWorldMap> m_WorldMaps;

	private readonly Dictionary<TransmitterData, AsyncOperationHandle<GameObject>> m_MapItems;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(ObjectPool<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "SetupTransmitterSites")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "SetupSliderSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "OnWorldMapChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectPool<>), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "UpdateScrollFromSmallMovement")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "SelectNextAvailableWorldMap")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallsUnknownMethods(Count = 1)]
	public void HandleControlInputs(Panel_Log owner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTransmitters")]
	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "HandleControlInputs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectNextAvailableWorldMap()
	{
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectPool<>), Member = "Get")]
	[Calls(Type = typeof(TransmitterSiteListItem), Member = "SetTransmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "MaybeSetupTransmitterMapItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetupTransmitterSites()
	{
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "MaybeSetupTransmitterMapItem")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Transform GetWorldMapParent(WorldMapSpecification worldMap)
	{
		return null;
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "SetupTransmitterSites")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(TransmitterSiteMapItem), Member = "SetTransmitter")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "GetWorldMapParent")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetupTransmitterMapItem(TransmitterData transmitter)
	{
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupSliderSettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ResetListPanelClipping()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTransmitters")]
	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "HandleControlInputs")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateScrollFromSmallMovement(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "get_IsActive")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private static int SortListItems(Transform x, Transform y)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsUnknownMethods(Count = 1)]
	private void SetWorldMapBasedOnCurrentRegionAsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[CallsUnknownMethods(Count = 1)]
	private void OnCurrentZoneLoaded(AsyncOperationHandle<ZoneSpecification> zoneOp)
	{
	}

	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void OnWorldMapChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private TransmitterSiteListItem CreateListItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnGetListItem(TransmitterSiteListItem obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnReleaseItem(TransmitterSiteListItem obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroyItem(TransmitterSiteListItem obj)
	{
	}

	[IteratorStateMachine(typeof(_003CResetSliderWhenAvailable_003Ed__35))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator ResetSliderWhenAvailable(int numberOfSteps)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public TransmitterSiteUIController()
	{
	}
}
