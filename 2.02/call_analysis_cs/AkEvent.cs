using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEvent : AkDragDropTriggerHandler
{
	[Serializable]
	public class CallbackData
	{
		public CallbackFlags Flags;

		public string FunctionName;

		public GameObject GameObject;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "SendMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CallbackData()
		{
		}
	}

	public AkActionOnEventType actionOnEventType;

	public AkCurveInterpolation curveInterpolation;

	public bool enableActionOnEvent;

	public AK.Wwise.Event data;

	public bool useCallbacks;

	public List<CallbackData> Callbacks;

	public uint playingId;

	public GameObject soundEmitterObject;

	public float transitionDuration;

	private AkEventCallbackMsg EventCallbackMsg;

	private int eventIdInternal;

	private byte[] valueGuidInternal;

	private AkEventCallbackData m_callbackDataInternal;

	protected override BaseType WwiseType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public int eventID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
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

	public AkEventCallbackData m_callbackData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(int _transitionDuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public AkEvent()
	{
	}
}
