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

	[CalledBy(Type = typeof(AkChannelEmitter), Member = "set_position")]
	[CalledBy(Type = typeof(AkDiffractionPathInfo), Member = "set_virtualPos")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetPosition")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetListenerPosition")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetRoomPortal")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkTransform obj)
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
	~AkTransform()
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
