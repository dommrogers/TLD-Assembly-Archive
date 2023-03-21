using System;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin;
using UnityEngine;

public class UserReportingMonitor : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UserReportScreenshot> _003C_003E9__7_0;

		public static Action<UserReportScreenshot> _003C_003E9__7_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		internal void _003CTrigger_003Eb__7_0(UserReportScreenshot s)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal void _003CTrigger_003Eb__7_1(UserReportScreenshot s)
		{
		}
	}

	public bool IsEnabled;

	public bool IsEnabledAfterTrigger;

	public bool IsHiddenWithoutDimension;

	public string MonitorName;

	public string Summary;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public UserReportingMonitor()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(FramerateMonitor), Member = "Update")]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	public void Trigger()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Triggered()
	{
	}
}
