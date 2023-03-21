using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Users;

public class PicturePngData : IWrappedObject
{
	private IntPtr m_Self;

	private byte[] m_PictureBytes;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	public PicturePngData()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[CallerCount(Count = 0)]
	~PicturePngData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PicturePngData), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PicturePngData), Member = "Finalize")]
	[CalledBy(Type = typeof(PicturePngData), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
