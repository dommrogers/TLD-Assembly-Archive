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
		[CallerCount(Count = 80)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		protected set
		{
		}
	}

	public string m_ActiveMissionLocId
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	public GameModeConfig GameModeConfig
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
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

	public string m_FilePath
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 53)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		protected set
		{
		}
	}

	public ScreenshotSaveGameFormat m_Screenshot
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		protected set
		{
		}
	}

	public SlotData m_Slot
	{
		[CompilerGenerated]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected JumpData()
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public string GetTreePath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsStoryMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	public void Rename(string name)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentMode")]
	public static JumpData LoadFromFile(string path)
	{
		return null;
	}
}
