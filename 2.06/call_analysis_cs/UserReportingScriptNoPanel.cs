using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin;
using UnityEngine;

public class UserReportingScriptNoPanel : MonoBehaviour
{
	private class TLDUserReportingUpdater : IEnumerator
	{
		private WaitForEndOfFrame m_WaitForEndOfFrame;

		private object _003CCurrent_003Ek__BackingField;

		public object Current
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 85)]
			private set
			{
			}
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
		[CallerCount(Count = 1)]
		public TLDUserReportingUpdater()
		{
		}

		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UserReportingClient), Member = "Update")]
		[Calls(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
		[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	private TLDUserReportingUpdater m_UnityUserReportingUpdater;

	private Coroutine m_RunningCoroutine;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TLDUserReportingUpdater), Member = ".ctor")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UserReportingScriptNoPanel()
	{
	}
}
