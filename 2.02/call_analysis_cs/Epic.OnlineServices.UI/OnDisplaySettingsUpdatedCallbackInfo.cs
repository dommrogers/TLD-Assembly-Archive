using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

public class OnDisplaySettingsUpdatedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private bool _003CIsVisible_003Ek__BackingField;

	private bool _003CIsExclusiveInput_003Ek__BackingField;

	public object ClientData
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsVisible
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool IsExclusiveInput
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsVisible")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsExclusiveInput")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(OnDisplaySettingsUpdatedCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsVisible")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsExclusiveInput")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnDisplaySettingsUpdatedCallbackInfo()
	{
	}
}
