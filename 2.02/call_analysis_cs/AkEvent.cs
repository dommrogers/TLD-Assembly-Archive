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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "SendMessage")]
		[CallsUnknownMethods(Count = 3)]
		public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
			return default(int);
		}
	}

	public byte[] valueGuid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public AkEventCallbackData m_callbackData
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Stop(int _transitionDuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	[CalledBy(Type = typeof(AkAmbient), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public AkEvent()
	{
	}
}
