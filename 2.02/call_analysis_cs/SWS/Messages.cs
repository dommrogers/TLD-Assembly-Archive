using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

[Serializable]
public class Messages
{
	public List<MessageOptions> list;

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(splineMove), Member = "StartMove")]
	[CalledBy(Type = typeof(Messages), Member = "GetMessageOption")]
	[CalledBy(Type = typeof(navMove), Member = "StartMove")]
	[Calls(Type = typeof(MessageOptions), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Messages), Member = "AddEmptyToOption")]
	public void Initialize(int size)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(Messages), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public MessageOptions AddEmptyToOption(MessageOptions opt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 23)]
	public void FillOptionWithValues(MessageOptions opt)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Messages), Member = "Initialize")]
	public MessageOptions GetMessageOption(int waypoint)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(splineMove._003CNextWaypoint_003Ed__40), Member = "MoveNext")]
	[CalledBy(Type = typeof(splineMove._003CNextWaypoint_003Ed__40), Member = "MoveNext")]
	[CalledBy(Type = typeof(navMove._003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(navMove._003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(navMove._003CNextWaypoint_003Ed__19), Member = "MoveNext")]
	[CalledBy(Type = typeof(bezierMove), Member = "CheckPoint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Execute(MonoBehaviour mono, int index)
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Messages()
	{
	}
}
