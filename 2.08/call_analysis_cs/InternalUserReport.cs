using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
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
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CSend_003Eb__0(UserReportScreenshot ss)
		{
		}

		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 39)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(InternalUserReport), Member = "SubmitUserReport")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 13)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(MissionServicesManager), Member = "GetAllActiveMissionNamesAsString")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
		internal void _003CSend_003Eb__1(UserReport br)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<float, float> _003C_003E9__8_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		internal void _003CSubmitUserReport_003Eb__8_0(float uploadProgress, float downloadProgress)
		{
		}
	}

	private UserReportStates m_UserReportState;

	private UserReport m_CurrentUserReport;

	private int m_ThumbnailSize;

	private UserReportData m_UserReportData;

	private static InternalUserReport ms_Instance;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static InternalUserReport Instance()
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(Camera), Member = "get_aspect")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool Send(string messageType, string message, Action<string, string> onUserReportComplete)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	private void SubmitUserReport()
	{
	}

	[CallerCount(Count = 0)]
	public InternalUserReport()
	{
	}
}
