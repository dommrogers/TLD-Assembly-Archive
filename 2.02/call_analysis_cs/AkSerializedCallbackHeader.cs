using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkSerializedCallbackHeader : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public IntPtr pPackage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pPackage_get")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return (IntPtr)0;
		}
	}

	public AkSerializedCallbackHeader pNext
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pNext_get")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public AkCallbackType eType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_eType_get")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(AkCallbackType);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj)
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkSerializedCallbackHeader()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_GetData")]
	[CallsDeduplicatedMethods(Count = 1)]
	public IntPtr GetData()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkSerializedCallbackHeader()
	{
	}
}
