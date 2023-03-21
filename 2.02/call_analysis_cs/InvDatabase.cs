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
		[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsUnknownMethods(Count = 5)]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public static int FindItemID(InvBaseItem item)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public InvDatabase()
	{
	}
}
