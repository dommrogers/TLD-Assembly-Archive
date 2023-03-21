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
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (IntPtr)0;
		}
	}

	public bool IsVisible
	{
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
	}

	public bool IsExclusiveInput
	{
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnDisplaySettingsUpdatedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
	}
}
