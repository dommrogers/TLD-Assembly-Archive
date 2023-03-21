using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkExternalSourceInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint iExternalSrcCookie
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint idCodec
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string szFile
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrOSString")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_szFile_set")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IntPtr pInMemory
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(IntPtr);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint uiMemorySize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint idFile
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkExternalSourceInfoArray), Member = "CloneIntoReferenceFromIntPtr")]
	internal static IntPtr getCPtr(AkExternalSourceInfo obj)
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkExternalSourceInfo()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkExternalSourceInfo()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Clear()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clone")]
	[CallerCount(Count = 0)]
	public void Clone(AkExternalSourceInfo other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_GetSizeOf")]
	[CallerCount(Count = 0)]
	public static int GetSizeOf()
	{
		return default(int);
	}
}
