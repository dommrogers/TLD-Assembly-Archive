using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SessionSearchRemoveParameterOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	private ComparisonOp m_ComparisonOp;

	public string Key
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ComparisonOp ComparisonOp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "set_Key")]
	public void Set(SessionSearchRemoveParameterOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "set_Key")]
	[CalledBy(Type = typeof(SessionSearch), Member = "RemoveParameter")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
