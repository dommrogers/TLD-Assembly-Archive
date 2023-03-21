using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class PresenceModificationDataRecordId : ISettable
{
	private string _003CKey_003Ek__BackingField;

	public string Key
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
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "get_Key")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Set(PresenceModificationDataRecordIdInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "get_Key")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PresenceModificationDataRecordId()
	{
	}
}
