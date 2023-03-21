using System;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class DataMapView : IDisposable
{
	private IntPtr m_Self;

	public IntPtr NativePtr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 113)]
		get
		{
			return (IntPtr)0;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint Length(string name)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint Capacity(string name)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool FillBuffer(string name, int offset, byte[] data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public byte[] GetBuffer(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DataMapView(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
