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
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int FindItemID(InvBaseItem item)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvDatabase()
	{
	}
}
