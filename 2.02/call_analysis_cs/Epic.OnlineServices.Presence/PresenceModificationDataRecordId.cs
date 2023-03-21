using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class PresenceModificationDataRecordId : ISettable
{
	private string _003CKey_003Ek__BackingField;

	public string Key
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "get_Key")]
	[CallsUnknownMethods(Count = 1)]
	internal void Set(PresenceModificationDataRecordIdInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "get_Key")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PresenceModificationDataRecordId()
	{
	}
}
