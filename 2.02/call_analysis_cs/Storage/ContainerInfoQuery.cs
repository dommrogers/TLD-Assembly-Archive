using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class ContainerInfoQuery : IDisposable, IEnumerable<ContainerInfo>, IEnumerable
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public ContainerInfoQuery _003C_003E4__this;

		public uint idx;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal ulong _003CLastModifiedTime_003Eb__0()
		{
			return 0uL;
		}
	}

	private sealed class _003CGetEnumerator_003Ed__6 : IEnumerator<ContainerInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ContainerInfo _003C_003E2__current;

		public ContainerInfoQuery _003C_003E4__this;

		private uint _003Ci_003E5__2;

		private ContainerInfo System_002ECollections_002EGeneric_002EIEnumerator_003CStorage_002EContainerInfo_003E_002ECurrent
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
		public _003CGetEnumerator_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContainerInfoQuery), Member = "MarshalContainerInfo")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
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

	private IntPtr m_Self;

	public ContainerInfo Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContainerInfoQuery), Member = "MarshalContainerInfo")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ulong TotalSize(uint idx)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string Name(uint idx)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string DisplayName(uint idx)
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerInfoQuery), Member = "MarshalContainerInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public DateTime LastModifiedTime(uint idx)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool NeedsSync(uint idx)
	{
		return false;
	}

	[CalledBy(Type = typeof(ContainerInfoQuery), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<ContainerInfo> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerInfoQuery), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerInfoQuery), Member = "get_Item")]
	[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__6), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContainerInfoQuery), Member = "LastModifiedTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	protected void MarshalContainerInfo(ContainerInfo ci, uint i)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ContainerInfoQuery(uint totalResults, IntPtr queryHandle)
	{
	}
}
