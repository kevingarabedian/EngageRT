using System.Collections.Generic;

public class Settings
{
    public string name { get; set; }
    public string outboundPhoneNumber { get; set; }
    public string hostname { get; set; }
    public string mainMenu { get; set; }
    public string agentHuntMode { get; set; }
    public List<string> acceptedChannels { get; set; }
    public bool enableRecording { get; set; }
    public bool enableExitSurvey { get; set; }
    public bool enableCallback { get; set; }
    public bool enableInboundText { get; set; }
    public bool enableTextSummary { get; set; }
    public bool enableQueueStatsMessage { get; set; }
    public bool enableExitMessage { get; set; }
    public bool enableWaitingMusic { get; set; }
    public bool enableWrapUpUrl { get; set; }
    public string wrapUpUrl { get; set; }
    public string wrapUpUrlMethod { get; set; }
    public List<string> waitingMusics { get; set; }
    public Agents agents { get; set; }
    public Queues queues { get; set; }
    public Messages messages { get; set; }
    public Trees trees { get; set; }
}

public class Agents
{
    public AgentInfo agent0 { get; set; }
    public AgentInfo agent1 { get; set; }
    public AgentInfo agent2 { get; set; }
    // Add more agents as needed
}

public class AgentInfo
{
    public string name { get; set; }
    public Dictionary<string, ChannelInfo> channels { get; set; }
    public List<string> channelsEnabled { get; set; }
    public List<object> roles { get; set; }
    public Dictionary<string, List<SkillInfo>> skills { get; set; }
}

public class ChannelInfo
{
    public string endpoint { get; set; }
    public int maxInteractions { get; set; }
    public bool exclusiveInteraction { get; set; }
}

public class SkillInfo
{
    public int desirability { get; set; }
    public int proficiency { get; set; }
}

public class Queues
{
    public QueueInfo salesPartners { get; set; }
    public QueueInfo salesSupport { get; set; }
    public QueueInfo techSupport { get; set; }
    // Add more queues as needed
}

public class QueueInfo
{
    public string queueSid { get; set; }
}

public class Messages
{
    public string queueStatsMessage { get; set; }
    public string entryMessage { get; set; }
    public string exitMessage { get; set; }
}

public class Trees
{
    public TreeInfo main { get; set; }
    public TreeInfo sales { get; set; }
    public TreeInfo tech { get; set; }
}

public class TreeInfo
{
    public Dictionary<string, MenuOption> options { get; set; }
}

public class MenuOption
{
    public string verbiage { get; set; }
    public string action { get; set; }
}

public class Signalwire
{
    public string space { get; set; }
    public string project { get; set; }
    public string token { get; set; }
    public Dictionary<string, List<string>> contexts { get; set; }
    public string engine { get; set; }
}

public class Root
{
    public Settings settings { get; set; }
    public Signalwire signalwire { get; set; }
}
