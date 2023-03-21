using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class UserStatisticsResult : IDisposable, IEnumerable<ServiceConfigurationStatistic>, IEnumerable, IWrappedObject
{
	private sealed class _003CGetEnumerator_003Ed__3 : IEnumerator<ServiceConfigurationStatistic>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ServiceConfigurationStatistic _003C_003E2__current;

		public UserStatisticsResult _003C_003E4__this;

		private int _003Ci_003E5__2;

		private ServiceConfigurationStatistic System_002ECollections_002EGeneric_002EIEnumerator_003CDataPlatform_002EServiceConfigurationStatistic_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__3(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StatisticsManagerPlugin), Member = "StatisticsManager_UserStatisticsResult_ServiceConfigurationStatistics_GetAt")]
		[Calls(Type = typeof(ServiceConfigurationStatistic), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private ServiceConfigurationStatistic[] m_Results;

	private bool m_DoOwnSelf;

	private IntPtr m_Self;

	private string m_Xuid;

	public string XboxUserId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public ServiceConfigurationStatistic Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StatisticsManagerPlugin), Member = "StatisticsManager_UserStatisticsResult_ServiceConfigurationStatistics_GetAt")]
		[Calls(Type = typeof(ServiceConfigurationStatistic), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UserStatisticsResult), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<ServiceConfigurationStatistic> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserStatisticsResult), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UserStatisticsResult()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public UserStatisticsResult(IntPtr self, bool ownSelf)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserStatisticsResult), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~UserStatisticsResult()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserStatisticsResult), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(UserStatisticsResult), Member = "Finalize")]
	[CalledBy(Type = typeof(UserStatisticsResult), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
