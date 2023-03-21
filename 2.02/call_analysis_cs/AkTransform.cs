using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkTransform : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetListenerPosition")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetRoomPortal")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetPosition")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AkChannelEmitter), Member = "set_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkDiffractionPathInfo), Member = "set_virtualPos")]
	internal static IntPtr getCPtr(AkTransform obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	~AkTransform()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public AkVector Position()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public AkVector OrientationFront()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public AkVector OrientationTop()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	public void Set(AkVector in_position, AkVector in_orientationFront, AkVector in_orientationTop)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public void SetPosition(AkVector in_position)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetPosition(float in_x, float in_y, float in_z)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	public void SetOrientation(AkVector in_orientationFront, AkVector in_orientationTop)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkTransform()
	{
	}
}
