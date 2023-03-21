using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;
using UnityEngine;

namespace Unity.Cloud.UserReporting.Plugin;

public class UnityUserReportingUpdater : IEnumerator
{
	private int step;

	private WaitForEndOfFrame waitForEndOfFrame;

	private object _003CCurrent_003Ek__BackingField;

	public object Current
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		private set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReportingScript), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public UnityUserReportingUpdater()
	{
	}

	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
	[Calls(Type = typeof(UserReportingClient), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Reset()
	{
	}
}
