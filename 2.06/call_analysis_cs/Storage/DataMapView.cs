using System;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class DataMapView : IDisposable
{
	private IntPtr m_Self;

	public IntPtr NativePtr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		get
		{
			return default(IntPtr);
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint Length(string name)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public uint Capacity(string name)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool FillBuffer(string name, int offset, byte[] data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public byte[] GetBuffer(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DataMapView(IntPtr self)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
