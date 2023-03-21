using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Users;

public class PicturePngData : IWrappedObject
{
	private IntPtr m_Self;

	private byte[] m_PictureBytes;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public byte[] GetPictureBytes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PicturePngData(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PicturePngData()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~PicturePngData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(PicturePngData), Member = "Finalize")]
	[CalledBy(Type = typeof(PicturePngData), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
