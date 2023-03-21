using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public byte byChan
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byParam1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byParam2
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(byte);
		}
	}

	public AkMIDIEventTypes byType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkMIDIEventTypes);
		}
	}

	public byte byOnOffNote
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byVelocity
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public AkMIDICcTypes byCc
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(AkMIDICcTypes);
		}
	}

	public byte byCcValue
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byValueLsb
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byValueMsb
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byAftertouchNote
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byNoteAftertouchValue
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public byte byChanAftertouchValue
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(byte);
		}
	}

	public byte byProgramNum
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIEventCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIEventCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AkMIDIEventCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkMIDIEventCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkMIDIEventCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
