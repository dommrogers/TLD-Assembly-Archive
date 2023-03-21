using System;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class DataMap : IDisposable
{
	private IntPtr m_Self;

	public IntPtr NativePtr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return (IntPtr)0;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static DataMap Create()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static DataMap CreateFromDataMapView(DataMapView view)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AddNewBuffer(string name, int size)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataMapPlugin), Member = "DataMap_AddOrReplaceBuffer")]
	[CallsUnknownMethods(Count = 1)]
	public void AddOrReplaceBuffer(string name, byte[] data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataMapPlugin), Member = "DataMap_AddOrReplaceBuffer")]
	public void AddOrReplaceBuffer(string name, byte[] data, int len)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateBuffer(string name, int bufferOffset, byte[] data, int dataOffset)
	{
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public byte[] GetBuffer(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DataMap(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
