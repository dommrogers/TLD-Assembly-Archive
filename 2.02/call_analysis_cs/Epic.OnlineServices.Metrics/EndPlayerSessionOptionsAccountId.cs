using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

public class EndPlayerSessionOptionsAccountId : ISettable
{
	private MetricsAccountIdType m_AccountIdType;

	private EpicAccountId m_Epic;

	private string m_External;

	public MetricsAccountIdType AccountIdType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(MetricsAccountIdType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public EpicAccountId Epic
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "op_Implicit")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		set
		{
		}
	}

	public string External
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "op_Implicit")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_Epic")]
	[CallsUnknownMethods(Count = 8)]
	public static implicit operator EndPlayerSessionOptionsAccountId(EpicAccountId value)
	{
		return null;
	}

	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_External")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static implicit operator EndPlayerSessionOptionsAccountId(string value)
	{
		return null;
	}

	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_External")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_External")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_Epic")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_Epic")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Set(EndPlayerSessionOptionsAccountIdInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_Epic")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_Epic")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_External")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_External")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EndPlayerSessionOptionsAccountId()
	{
	}
}
