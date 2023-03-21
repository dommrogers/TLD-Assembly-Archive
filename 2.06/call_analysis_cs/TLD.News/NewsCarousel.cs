using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using TLD.OptionalContent;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.Networking;

namespace TLD.News;

public class NewsCarousel : MonoBehaviour
{
	private enum NewsState
	{
		Uninitialized,
		FetchingNews,
		LoadingItems,
		Ready
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public NewsCarousel _003C_003E4__this;

		public int index;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
		[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CSetupPipClick_003Eb__0()
		{
		}
	}

	private sealed class _003CDownloadAllBackgrounds_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NewsCarousel _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CDownloadAllBackgrounds_003Ed__40(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(NewsCarousel), Member = "DownloadTexture")]
		[Calls(Type = typeof(NewsCarousel), Member = "SetupPips")]
		[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public NewsCarousel _003C_003E4__this;

		public string url;

		public NewsItem newsItem;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		internal void _003CDownloadTexture_003Eb__0(UnityWebRequest succesResponse)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CDownloadTexture_003Eb__1(UnityWebRequest failResponse)
		{
		}
	}

	private const string SURVIVAL_SKU = "tld_survival";

	private const string TFTFT_SKU = "tld_tftft";

	private const string COMPLETE_SKU = "tld_complete";

	private static readonly LogFilter s_LogFilter;

	private float m_TimeBetweenItems;

	private GameObject m_LoadingRoot;

	private GameObject m_FallbackRoot;

	private GameObject m_ItemRoot;

	private GameObject m_ItemTypeHeader;

	private UITexture m_ItemBackground;

	private UILabel m_ItemTitle;

	private UILabel m_ItemBody;

	private GameObject m_ItemSeeMoreButton;

	private GameObject m_ItemStoreButton;

	private GameObject m_PipRoot;

	private List<UIButton> m_Pips;

	private Color m_ActivePipColor;

	private Color m_InactivePipColor;

	private float m_PipSpacing;

	private Transform m_LeftControllerButton;

	private Transform m_RightControllerButton;

	private OptionalContentConfig m_ExpansionPassConfig;

	private OptionalContentConfig m_WintermuteConfig;

	private NewsProvider m_News;

	private NewsState m_NewsState;

	private List<string> m_ActiveBackgroundDownloads;

	private bool m_IsActive;

	private float m_NextItemTimer;

	private int m_CurrentItemIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewsCarousel), Member = "ResetNews")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetupPipClick")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void SetupPipClick(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewsCarousel), Member = "ResetNews")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetActive(bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	public void UpdateCarousel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetNewsState(NewsState state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void WaitForInitialization()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(NewsProvider), Member = "GenerateQuery")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(NewsCarousel), Member = "FinishNewsFetching")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void RetrieveNewsFromServer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[CallsUnknownMethods(Count = 1)]
	private string GetSKU()
	{
		return null;
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "<RetrieveNewsFromServer>b__37_0")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "<RetrieveNewsFromServer>b__37_1")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NewsProvider), Member = "ParseJson")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void FinishNewsFetching(string newsJson)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadAllBackgrounds_003Ed__40))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator DownloadAllBackgrounds()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void DownloadTexture(NewsItem newsItem, string url)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewsCarousel), Member = "SetupPips")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void FinishSettingUpNews()
	{
	}

	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "FinishSettingUpNews")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void SetupPips(int count)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(NewsCarousel), Member = "MoveToNextItem")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[Calls(Type = typeof(NewsCarousel), Member = "ResetNews")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActiveCarousel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	private void OnPipButtonClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnItemButtonClicked()
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CallsUnknownMethods(Count = 1)]
	private void MoveToNextItem()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MoveToPreviousItem()
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass31_0), Member = "<SetupPipClick>b__0")]
	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "FinishSettingUpNews")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnPipButtonClicked")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "MoveToNextItem")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateNewsItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetActiveItem(int index)
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateNewsItem(NewsItem item, bool isNew)
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "Awake")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnDestroy")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void ResetNews()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public NewsCarousel()
	{
	}
}
