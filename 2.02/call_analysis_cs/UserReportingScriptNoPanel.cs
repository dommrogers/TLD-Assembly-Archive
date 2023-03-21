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
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 71)]
			private set
			{
			}
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
		[CallsUnknownMethods(Count = 7)]
		public TLDUserReportingUpdater()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[Calls(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
		[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
		[Calls(Type = typeof(UserReportingClient), Member = "Update")]
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

	private TLDUserReportingUpdater m_UnityUserReportingUpdater;

	private Coroutine m_RunningCoroutine;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[Calls(Type = typeof(TLDUserReportingUpdater), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UserReportingScriptNoPanel()
	{
	}
}
