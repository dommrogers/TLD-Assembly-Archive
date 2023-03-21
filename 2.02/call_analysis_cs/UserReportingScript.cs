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
	private sealed class _003CClearError_003Ed__27 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserReportingScript _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		internal void _003CCreateUserReport_003Eb__29_0(UserReportScreenshot s)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal void _003CCreateUserReport_003Eb__29_1(UserReportScreenshot s)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		internal void _003CStart_003Eb__33_0(float upload, float download)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	[Calls(Type = typeof(UnityUserReportingUpdater), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UserReportingScript()
	{
	}

	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	public void CancelUserReport()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReportingScript), Member = "<SubmitUserReport>b__34_1")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator ClearError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearForm()
	{
	}

	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "Update")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallerCount(Count = 1)]
	public void CreateUserReport()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	private UserReportingClientConfiguration GetConfiguration()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsSubmitting()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[Calls(Type = typeof(Image), Member = "set_sprite")]
	[Calls(Type = typeof(Sprite), Member = "Create")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	private void SetThumbnail(UserReport userReport)
	{
	}

	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(UserReportingScript), Member = "GetConfiguration")]
	[Calls(Type = typeof(UserReportingScript), Member = "GetConfiguration")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	public void SubmitUserReport()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
	protected virtual void RaiseUserReportSubmitting()
	{
	}
}
