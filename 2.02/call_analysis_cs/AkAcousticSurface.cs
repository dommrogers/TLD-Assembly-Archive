using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkAcousticSurface : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint textureID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint reflectorChannelMask
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string strName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkAcousticSurfaceArray), Member = "CloneIntoReferenceFromIntPtr")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkAcousticSurface obj)
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
	~AkAcousticSurface()
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkAcousticSurface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DeleteName()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_GetSizeOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetSizeOf()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clone")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clone(AkAcousticSurface other)
	{
	}
}
