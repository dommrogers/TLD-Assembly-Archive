using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class BlobInfoQuery : IDisposable, IEnumerable<BlobInfo>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__3 : IEnumerator<BlobInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private BlobInfo _003C_003E2__current;

		public BlobInfoQuery _003C_003E4__this;

		private uint _003Ci_003E5__2;

		private BlobInfo System_002ECollections_002EGeneric_002EIEnumerator_003CStorage_002EBlobInfo_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[Calls(Type = typeof(BlobInfoQuery), Member = "TotalSize")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(BlobInfoQuery), Member = "Name")]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
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

	public BlobInfo Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlobInfoQuery), Member = "Name")]
		[Calls(Type = typeof(BlobInfoQuery), Member = "TotalSize")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(BlobInfoQuery), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	public uint TotalSize(uint idx)
	{
		return default(uint);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(BlobInfoQuery), Member = "get_Item")]
	[CallsUnknownMethods(Count = 3)]
	public string Name(uint idx)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__3))]
	public IEnumerator<BlobInfo> GetEnumerator()
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BlobInfoQuery(uint totalResults, IntPtr queryHandle)
	{
	}
}
