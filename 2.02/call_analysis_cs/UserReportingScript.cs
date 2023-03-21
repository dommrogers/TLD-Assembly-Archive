using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UserReportingScript : MonoBehaviour
{
	private sealed class _003CClearError_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserReportingScript _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CClearError_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UserReportScreenshot> _003C_003E9__29_0;

		public static Action<UserReportScreenshot> _003C_003E9__29_1;

		public static Action<float, float> _003C_003E9__33_0;

		public static Action<bool, byte[]> _003C_003E9__33_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CCreateUserReport_003Eb__29_0(UserReportScreenshot s)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CCreateUserReport_003Eb__29_1(UserReportScreenshot s)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CStart_003Eb__33_0(float upload, float download)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CStart_003Eb__33_1(bool result, byte[] bytes)
		{
		}
	}

	public Dropdown CategoryDropdown;

	public InputField DescriptionInput;

	public Canvas ErrorPopup;

	private bool isCreatingUserReport;

	public bool IsHotkeyEnabled;

	public bool IsInSilentMode;

	public bool IsSelfReporting;

	private bool isShowingError;

	private bool isSubmitting;

	public Text ProgressText;

	public bool SendEventsToAnalytics;

	public Canvas SubmittingPopup;

	public InputField SummaryInput;

	public Image ThumbnailViewer;

	private UnityUserReportingUpdater unityUserReportingUpdater;

	public Button UserReportButton;

	public Canvas UserReportForm;

	public UserReportingPlatformType UserReportingPlatform;

	public UnityEvent UserReportSubmitting;

	private UserReport _003CCurrentUserReport_003Ek__BackingField;

	public UserReport CurrentUserReport
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private set
		{
		}
	}

	public UserReportingState State
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(UserReportingState);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	[Calls(Type = typeof(UnityUserReportingUpdater), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public UserReportingScript()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	public void CancelUserReport()
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "<SubmitUserReport>b__34_1")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator ClearError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearForm()
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void CreateUserReport()
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private UserReportingClientConfiguration GetConfiguration()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsSubmitting()
	{
		return false;
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[Calls(Type = typeof(Sprite), Member = "Create")]
	[Calls(Type = typeof(Image), Member = "set_sprite")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void SetThumbnail(UserReport userReport)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(UserReportingScript), Member = "GetConfiguration")]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 33)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 36)]
	public void SubmitUserReport()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
	protected virtual void RaiseUserReportSubmitting()
	{
	}
}
