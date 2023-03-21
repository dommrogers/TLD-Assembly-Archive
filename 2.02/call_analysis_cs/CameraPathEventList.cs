using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathEventList : CameraPathPointList
{
	public delegate void CameraPathEventPointHandler(string name);

	private float _lastPercentage;

	public new CameraPathEvent Item
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public event CameraPathEventPointHandler CameraPathEventPoint
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnEnable")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void AddEvent(CameraPathControlPoint atPoint)
	{
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public CameraPathEvent AddEvent(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnAnimationStart(float startPercentage)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathEventList), Member = "Call")]
	[CalledBy(Type = typeof(CameraPath), Member = "CheckEvents")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "CheckEvents")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void CheckEvents(float percentage)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void BroadCast(CameraPathEvent eventPoint)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void Call(CameraPathEvent eventPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathEventList()
	{
	}
}
