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
		[CallerCount(Count = 9)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Load(bool decodeBank = false, bool saveDecodedBank = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBankAsync")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void LoadAsync(AkCallbackManager.BankCallback callback = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBankManager), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Unload()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Bank()
	{
	}
}
