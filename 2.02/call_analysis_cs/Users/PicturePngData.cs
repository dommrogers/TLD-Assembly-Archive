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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	public byte[] GetPictureBytes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PicturePngData(IntPtr self)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PicturePngData()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~PicturePngData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(PicturePngData), Member = "Dispose")]
	[CalledBy(Type = typeof(PicturePngData), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DisposeImpl()
	{
	}
}
