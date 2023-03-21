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

		[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
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
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CDownloadAllBackgrounds_003Ed__40(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(NewsCarousel), Member = "DownloadTexture")]
		[Calls(Type = typeof(NewsCarousel), Member = "SetupPips")]
		[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 13)]
		private bool MoveNext()
		{
			return default(bool);
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		internal void _003CDownloadTexture_003Eb__0(UnityWebRequest succesResponse)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void SetNewsState(NewsState state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void WaitForInitialization()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(NewsCarousel), Member = "FinishNewsFetching")]
	[Calls(Type = typeof(NewsProvider), Member = "GenerateQuery")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void RetrieveNewsFromServer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	private string GetSKU()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NewsProvider), Member = "ParseJson")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "<RetrieveNewsFromServer>b__37_0")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "<RetrieveNewsFromServer>b__37_0")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "<RetrieveNewsFromServer>b__37_1")]
	private void FinishNewsFetching(string newsJson)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CDownloadAllBackgrounds_003Ed__40))]
	private IEnumerator DownloadAllBackgrounds()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 17)]
	private void DownloadTexture(NewsItem newsItem, string url)
	{
	}

	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NewsCarousel), Member = "SetupPips")]
	[CallsUnknownMethods(Count = 3)]
	private void FinishSettingUpNews()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "FinishSettingUpNews")]
	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void SetupPips(int count)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NewsCarousel), Member = "MoveToNextItem")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[Calls(Type = typeof(NewsCarousel), Member = "ResetNews")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(NewsCarousel), Member = "MoveToNextItem")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	private void UpdateActiveCarousel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CallerCount(Count = 0)]
	private void OnPipButtonClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnItemButtonClicked()
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CallsUnknownMethods(Count = 1)]
	private void MoveToNextItem()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void MoveToPreviousItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "MoveToNextItem")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "FinishSettingUpNews")]
	[CalledBy(Type = typeof(_003CDownloadAllBackgrounds_003Ed__40), Member = "MoveNext")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnPipButtonClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateNewsItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass31_0), Member = "<SetupPipClick>b__0")]
	private void SetActiveItem(int index)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "SetActiveItem")]
	private void UpdateNewsItem(NewsItem item, bool isNew)
	{
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "Awake")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnDestroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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
