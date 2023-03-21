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
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NGUITools), Member = "FindActive")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static int FindItemID(InvBaseItem item)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public InvDatabase()
	{
	}
}
