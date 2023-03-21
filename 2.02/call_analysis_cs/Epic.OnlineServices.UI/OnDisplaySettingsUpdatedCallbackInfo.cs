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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
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
			return false;
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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsVisible")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsExclusiveInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(OnDisplaySettingsUpdatedCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsVisible")]
	[Calls(Type = typeof(OnDisplaySettingsUpdatedCallbackInfoInternal), Member = "get_IsExclusiveInput")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public OnDisplaySettingsUpdatedCallbackInfo()
	{
	}
}
