using System;
using Cpp2ILInjected.CallAnalysis;

namespace AK.Wwise;

[Serializable]
public class Bank : BaseType
{
	public WwiseBankReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBank")]
	[CallerCount(Count = 0)]
	public void Load(bool decodeBank = false, bool saveDecodedBank = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBankAsync")]
	public void LoadAsync(AkCallbackManager.BankCallback callback = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkBankManager), Member = "UnloadBank")]
	public void Unload()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Bank()
	{
	}
}
