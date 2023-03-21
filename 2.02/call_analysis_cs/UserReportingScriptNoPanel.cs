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
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
			private set
			{
			}
		}

		[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public TLDUserReportingUpdater()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[Calls(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
		[Calls(Type = typeof(UserReportingClient), Member = "Update")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public bool MoveNext()
		{
			return false;
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
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(TLDUserReportingUpdater), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UserReportingScriptNoPanel()
	{
	}
}
