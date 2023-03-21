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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 79)]
			private set
			{
			}
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public TLDUserReportingUpdater()
		{
		}

		[Calls(Type = typeof(UserReportingClient), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[Calls(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
		[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UserReportingScriptNoPanel()
	{
	}
}
