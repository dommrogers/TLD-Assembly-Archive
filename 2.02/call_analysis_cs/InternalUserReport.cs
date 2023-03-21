using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin;
using UnityEngine;

public class InternalUserReport
{
	private struct UserReportData
	{
		public string m_MessageType;

		public string m_Summary;

		public List<string> m_Description;

		public List<string> m_Callstack;
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Action<string, string> onUserReportComplete;

		public string messageType;

		public string message;

		public InternalUserReport _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal void _003CSend_003Eb__0(UserReportScreenshot ss)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
		[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
		[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
		[Calls(Type = typeof(MissionServicesManager), Member = "GetAllActiveMissionNamesAsString")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(InternalUserReport), Member = "SubmitUserReport")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 78)]
		internal void _003CSend_003Eb__1(UserReport br)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<float, float> _003C_003E9__8_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CSubmitUserReport_003Eb__8_0(float uploadProgress, float downloadProgress)
		{
		}
	}

	private UserReportStates m_UserReportState;

	private UserReport m_CurrentUserReport;

	private int m_ThumbnailSize;

	private UserReportData m_UserReportData;

	private static InternalUserReport ms_Instance;

	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static InternalUserReport Instance()
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(Camera), Member = "get_aspect")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 82)]
	public bool Send(string messageType, string message, Action<string, string> onUserReportComplete)
	{
		return false;
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 41)]
	private void SubmitUserReport()
	{
	}

	[CallerCount(Count = 0)]
	public InternalUserReport()
	{
	}
}
