using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvDatabase : MonoBehaviour
{
	private static InvDatabase[] mList;

	private static bool mIsDirty;

	public int databaseID;

	public List<InvBaseItem> items;

	public UIAtlas iconAtlas;

	public static InvDatabase[] list
	{
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 2)]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallerCount(Count = 0)]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int FindItemID(InvBaseItem item)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public InvDatabase()
	{
	}
}
