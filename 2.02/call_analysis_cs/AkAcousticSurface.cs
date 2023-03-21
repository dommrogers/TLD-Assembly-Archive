using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkAcousticSurface : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint textureID
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public uint reflectorChannelMask
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public string strName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkAcousticSurfaceArray), Member = "CloneIntoReferenceFromIntPtr")]
	internal static IntPtr getCPtr(AkAcousticSurface obj)
	{
		return default(IntPtr);
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clear")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_GetSizeOf")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clone")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clone(AkAcousticSurface other)
	{
	}
}
