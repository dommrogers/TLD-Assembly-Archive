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
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		internal void _003CTrigger_003Eb__7_0(UserReportScreenshot s)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(FramerateMonitor), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[Calls(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public void Trigger()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void Triggered()
	{
	}
}
