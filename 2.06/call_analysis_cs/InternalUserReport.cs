using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CSend_003Eb__0(UserReportScreenshot ss)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public static InternalUserReport Instance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 62)]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(Camera), Member = "get_aspect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool Send(string messageType, string message, Action<string, string> onUserReportComplete)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	private void SubmitUserReport()
	{
	}

	[CallerCount(Count = 0)]
	public InternalUserReport()
	{
	}
}
