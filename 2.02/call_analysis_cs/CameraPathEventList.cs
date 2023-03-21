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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public event CameraPathEventPointHandler CameraPathEventPoint
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnEnable")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void AddEvent(CameraPathControlPoint atPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CalledBy(Type = typeof(CameraPath), Member = "CheckEvents")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "CheckEvents")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathEventList), Member = "Call")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void CheckEvents(float percentage)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void BroadCast(CameraPathEvent eventPoint)
	{
	}

	[CalledBy(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Call(CameraPathEvent eventPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathEventList()
	{
	}
}
