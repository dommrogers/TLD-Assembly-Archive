using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkImageSourceSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkImageSourceParams params_
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetImageSource")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetImageSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	internal static IntPtr getCPtr(AkImageSourceSettings obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AkImageSourceSettings()
	{
	}

	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public AkImageSourceSettings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public AkImageSourceSettings(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetOneTexture(uint in_texture)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void SetName(string in_pName)
	{
	}
}
