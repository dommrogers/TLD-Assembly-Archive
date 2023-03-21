using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkVector : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public float X
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float Z
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkVector(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkImageSourceParams), Member = ".ctor")]
	[CalledBy(Type = typeof(AkImageSourceParams), Member = "set_sourcePosition")]
	[CalledBy(Type = typeof(AkImageSourceSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(AkPathParams), Member = "set_listenerPos")]
	[CalledBy(Type = typeof(AkPathParams), Member = "set_emitterPos")]
	[CalledBy(Type = typeof(AkPropagationPathInfo), Member = "set_nodePoint")]
	[CalledBy(Type = typeof(AkReflectionPathInfo), Member = "set_imageSource")]
	[CalledBy(Type = typeof(AkReflectionPathInfo), Member = "set_occlusionPoint")]
	[CalledBy(Type = typeof(AkRoomParams), Member = "set_Up")]
	[CalledBy(Type = typeof(AkRoomParams), Member = "set_Front")]
	[CalledBy(Type = typeof(AkTransform), Member = "Set")]
	[CalledBy(Type = typeof(AkTransform), Member = "SetPosition")]
	[CalledBy(Type = typeof(AkTransform), Member = "SetOrientation")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "QueryReflectionPaths")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetRoomPortal")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkVector obj)
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
	~AkVector()
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Zero()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkVector()
	{
	}
}
