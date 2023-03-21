using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class ServiceConfigurationStatistic : IEnumerable<Statistic>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__3 : IEnumerator<Statistic>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Statistic _003C_003E2__current;

		public ServiceConfigurationStatistic _003C_003E4__this;

		private int _003Ci_003E5__2;

		private Statistic System_002ECollections_002EGeneric_002EIEnumerator_003CDataPlatform_002EStatistic_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
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
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ServiceConfigurationStatisticPlugin), Member = "ServiceConfigurationStatistic_GetAt")]
		[CallsUnknownMethods(Count = 11)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private IntPtr m_Self;

	private string m_SCID;

	private Statistic[] m_Results;

	public string ServiceConfigurationId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public Statistic Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ServiceConfigurationStatisticPlugin), Member = "ServiceConfigurationStatistic_GetAt")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__3))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public IEnumerator<Statistic> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CalledBy(TypeFullName = "DataPlatform.UserStatisticsResult.<GetEnumerator>d__3", Member = "MoveNext")]
	[CalledBy(Type = typeof(UserStatisticsResult), Member = "get_Item")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ServiceConfigurationStatistic(IntPtr self)
	{
	}
}
