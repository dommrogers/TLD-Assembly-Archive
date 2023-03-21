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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__3(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BlobInfoQuery), Member = "Name")]
		[Calls(Type = typeof(BlobInfoQuery), Member = "TotalSize")]
		[CallsUnknownMethods(Count = 10)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private IntPtr m_Self;

	public BlobInfo Item
	{
		[Calls(Type = typeof(BlobInfoQuery), Member = "Name")]
		[Calls(Type = typeof(BlobInfoQuery), Member = "TotalSize")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BlobInfoQuery), Member = "get_Item")]
	[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__3), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public uint TotalSize(uint idx)
	{
		return default(uint);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__3), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BlobInfoQuery), Member = "get_Item")]
	public string Name(uint idx)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlobInfoQuery), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<BlobInfo> GetEnumerator()
	{
		return null;
	}

	[Calls(Type = typeof(BlobInfoQuery), Member = "GetEnumerator")]
	[CallerCount(Count = 0)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BlobInfoQuery(uint totalResults, IntPtr queryHandle)
	{
	}
}
