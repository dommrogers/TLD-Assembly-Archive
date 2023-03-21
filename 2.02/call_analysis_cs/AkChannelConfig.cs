using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkChannelConfig : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint uNumChannels
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	public uint eConfigType
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint uChannelMask
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetListenerSpatialization")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetBusConfig")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetBusConfig")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "SetListenerSpatialization")]
	[CalledBy(Type = typeof(AkOutputSettings), Member = "set_channelConfig")]
	[CalledBy(Type = typeof(AkOutputSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(AkAudioFormat), Member = "SetAll")]
	[CalledBy(Type = typeof(AkAudioFormat), Member = "set_channelConfig")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(AkOutputSettings), Member = ".ctor")]
	internal static IntPtr getCPtr(AkChannelConfig obj)
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
	~AkChannelConfig()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkChannelConfig()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetStandard(uint in_uChannelMask)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetAnonymous(uint in_uNumChannels)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetAmbisonic(uint in_uNumChannels)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public uint Serialize()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(uint in_uChannelConfig)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public AkChannelConfig RemoveLFE()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public AkChannelConfig RemoveCenter()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsChannelConfigSupported()
	{
		return default(bool);
	}
}
