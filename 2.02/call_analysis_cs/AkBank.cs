using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkBank : AkTriggerHandler
{
	public Bank data;

	public bool decodeBank;

	public bool loadAsynchronous;

	public bool saveDecodedBank;

	public List<int> unloadTriggerList;

	private string bankNameInternal;

	private byte[] valueGuidInternal;

	public string bankName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public byte[] valueGuid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Awake")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "RegisterTriggers")]
	[Calls(Type = typeof(AkBank), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[Calls(Type = typeof(AkBank), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBankAsync")]
	[Calls(Type = typeof(AkBankManager), Member = "LoadBank")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "Awake")]
	[CalledBy(Type = typeof(AkBank), Member = "Start")]
	[CalledBy(Type = typeof(AkBank), Member = "OnDestroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkBankManager), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void UnloadBank(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "UnregisterTriggers")]
	[Calls(Type = typeof(AkBank), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public AkBank()
	{
	}
}
