using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct OnDisplaySettingsUpdatedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private int m_IsVisible;

	private int m_IsExclusiveInput;

	public object ClientData
	{
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(IntPtr);
		}
	}

	public bool IsVisible
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		get
		{
			return default(bool);
		}
	}

	public bool IsExclusiveInput
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		get
		{
			return default(bool);
		}
	}
}
