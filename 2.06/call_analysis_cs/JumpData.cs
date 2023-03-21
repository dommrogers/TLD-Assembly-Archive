using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.Encryption;
using TLD.Gameplay;
using TLD.Serialization;
using UnityEngine;

public class JumpData
{
	public const string EDITOR_FILE_TO_LOAD = "JMPED_FileToLoad";

	public const int DISPLAY_NAME_MAX_LENGTH = 20;

	private string _003Cm_ActiveMissionId_003Ek__BackingField;

	private string _003Cm_ActiveMissionLocId_003Ek__BackingField;

	private GameModeConfig _003CGameModeConfig_003Ek__BackingField;

	public int m_EditorId;

	private string _003Cm_FilePath_003Ek__BackingField;

	private float _003Cm_HoursSurvived_003Ek__BackingField;

	private string _003Cm_Location_003Ek__BackingField;

	private ScreenshotSaveGameFormat _003Cm_Screenshot_003Ek__BackingField;

	private SlotData _003Cm_Slot_003Ek__BackingField;

	public string m_ActiveMissionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		protected set
		{
		}
	}

	public string m_ActiveMissionLocId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		protected set
		{
		}
	}

	public GameModeConfig GameModeConfig
	{
		[CallerCount(Count = 23)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string m_FilePath
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 56)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		protected set
		{
		}
	}

	public float m_HoursSurvived
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string m_Location
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		protected set
		{
		}
	}

	public ScreenshotSaveGameFormat m_Screenshot
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		protected set
		{
		}
	}

	public SlotData m_Slot
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		protected set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected JumpData()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	public override string ToString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public string GetTreePath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsStoryMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 2)]
	public void Rename(string name)
	{
	}

	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentMode")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static JumpData LoadFromFile(string path)
	{
		return null;
	}
}
