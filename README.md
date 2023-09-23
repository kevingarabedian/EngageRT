# EngageRT - Simple Call Center

EngageRT is a powerful real-time customer engagement platform built to enhance your call center, support service, or any customer-facing communication system. It provides comprehensive tools for managing agents, queues, and customer interactions.

## Configuration

Before getting started, configure your EngageRT system by creating a `config.json` file with the following structure:

```json
{
  "settings": {
    "name": "Kevin's Contact Center",
    "outboundPhoneNumber": "--redacted--",
    "hostname": "http://--redacted--",
    "mainMenu": "main",
    "agentHuntMode": "Longest_Idle",
    "acceptedChannels": ["audio", "video", "push", "sms", "chat", "email"],
    "enableRecording": false,
    "enableExitSurvey": false,
    "enableCallback": false,
    "enableInboundText": false,
    "enableTextSummary": false,
    "enableQueueStatsMessage": true,
    "enableExitMessage": false,
    "enableWaitingMusic": true,
    "enableWrapUpUrl": false,
    "wrapUpUrl": "/some/endpoint/to/handle/post/call/stuff",
    "wrapUpUrlMethod": "POST",
    "waitingMusics": ["https://sinergyds.blob.core.windows.net/signalwire/popcorn.mp3"],
    "agents": {
      "0": {
        "name": "Kevin G.",
        "channels": {
          "audio": {
            "endpoint": "sip:--redacted--@--redacted--"
          },
          "video": {
            "endpoint": "--redacted--"
          },
          "sms": {
            "endpoint": "/some/url/to/process/this"
          },
          "push": {
            "endpoint": "--redacted--"
          },
          "chat": {
            "endpoint": "/some/chat/endpoint"
          },
          "email": {
            "endpoint": "mailto:support@example.com"
          }
        },
        "channelsEnabled": ["audio", "video", "sms", "push", "chat", "email"],
        "roles": [],
        "skills": {
          "english": [
            {
              "desirability": 1,
              "proficiency": 1
            }
          ],
          "spanish": [
            {
              "desirability": 0,
              "proficiency": 0
            }
          ]
        }
      }
    },
    "queues": {
      "salesPartners": {
        "queueSid": "--redacted--"
      },
      "salesSupport": {
        "queueSid": "--redacted--"
      },
      "techSupport": {
        "queueSid": "--redacted--"
      }
    },
    "messages": {
      "queueStatsMessage": "You are position ... %QueuePosition% ... of ...%CurrentQueueSize% ... Callers with an average wait time of ...%AvgQueueTime% ... seconds. Thank you for holding.",
      "entryMessage": "Thank You For Calling Kevin's Excellent Call Center!!",
      "exitMessage": "Thank You For Calling! The real O Gs.. Original Geeks!  Remember you can reach us on the web at signalwire dot com"
    },
    "trees": {
      "main": {
        "1": {
          "verbiage": "For Sales, Press 1",
          "action": "/get_menu?menu=sales"
        },
        "2": {
          "verbiage": "For Tech Support, Press 2",
          "action": "/get_menu?menu=tech"
        }
      },
      "sales": {
        "1": {
          "verbiage": "For Partners, Press 1",
          "action": "/enter_queue?name=salesPartners"
        },
        "2": {
          "verbiage": "For Help With Your Purchase, Press 2",
          "action": "/enter_queue?name=salesSupport"
        }
      },
      "tech": {
        "1": {
          "verbiage": "For issues with your internet, press 1",
          "action": "/enter_queue?name=techSupport"
        },
        "2": {
          "verbiage": "For issues with your cell phone, press 2",
          "action": "/get_voicemail?group=mobileSupport"
        }
      }
    }
  },
  "signalwire": {
    "space": "",
    "project": "",
    "token": "",
    "contexts": {
      "context1": ["audio", "video", "sms"],
      "context2": ["chat", "email"]
    },
    "engine": "laml"
  }
}
```

### Sample JSON Configuration

The sample JSON configuration provides an example of how to set up your EngageRT system. Here's a breakdown of key configuration elements:

- **Settings**: Configure your contact center's name, outbound phone number, hostname, agent hunt mode, accepted channels, and more.

- **Agents**: Define your agents' information, including their names, communication channels, roles, and skills.

- **Queues**: Specify your queues with unique identifiers and relevant information.

- **Messages**: Customize messages for queue stats, entry, and exit announcements.

- **Trees**: Create interactive menus with actions for routing calls effectively.

## Methods

EngageRT supports the following methods:

1. `conference_event`: Handle conference events.
2. `wait_music_queue`: Manage wait music in the queue.
3. `enqueue_event`: Enqueue events.
4. `voice_event`: Handle voice events.
5. `inbound_sms`: Process inbound SMS messages.
6. `post_conference`: Handle post-conference events.
7. `enter_queue`: Enter the queue.
8. `connect_agent`: Connect with an agent.
9. `connect_caller`: Connect a caller.
10. `inbound_voice`: Process inbound voice calls.
11. `get_menu`: Retrieve menu options.
12. `get_survey`: Get survey information.
13. `get_voicemail`: Retrieve voicemail messages.
14. `make_connection`: Establish a connection.
15. `api/logs/<name>`: Retrieve logs by name.

## Endpoints

EngageRT exposes the following endpoints for interaction:

1. `/conference_event` (GET or POST): Handle conference events.
2. `/wait_music_queue` (GET or POST): Manage wait music in the queue.
3. `/enqueue_event` (GET or POST): Enqueue events.
4. `/voice_event` (GET or POST): Handle voice events.
5. `/inbound_sms` (GET or POST): Process inbound SMS messages.
6. `/post_conference` (GET or POST): Handle post-conference events.
7. `/enter_queue` (GET or POST): Enter the queue.
8. `/connect_agent` (GET or POST): Connect with an agent.
9. `/connect_caller` (GET or POST): Connect a caller.
10. `/inbound_voice` (GET or POST): Process inbound voice calls.
11. `/get_menu` (GET or POST): Retrieve menu options for interaction.
12. `/get_survey` (GET or POST): Get survey information for customer feedback.
13. `/get_voicemail` (GET or POST): Retrieve voicemail messages.
14. `/make_connection` (GET): Establish a connection with the EngageRT platform.
15. `/api/logs/<name>` (GET): Retrieve logs by name for monitoring and debugging.

## Docker Instructions

To deploy EngageRT using Docker, follow these steps:

1. Clone the EngageRT repository:

   ```bash
   git clone https://github.com/your-username/EngageRT.git
   ```

2. Navigate to the project directory:

   ```bash
   cd EngageRT
   ```

3. Build the Docker image:

   ```bash
   docker build -t engagert:latest .
   ```

4. Run the Docker container:

   ```bash
   docker run -d -p 80:80 engagert:latest
   ```

Now, EngageRT should be up and running inside a Docker container, accessible on port 80 of your local machine.

## About SignalWire

EngageRT is designed to work seamlessly with SignalWire, a leading cloud communications platform. SignalWire offers disruptive technology that simplifies and enhances communication systems, making them more reliable, scalable, and efficient.

We recommend using SignalWire in conjunction with EngageRT to take full advantage of the platform's capabilities, ensuring high-quality interactions with your customers.

For more information about SignalWire and their cutting-edge communication solutions, please visit [SignalWire's website](https://www.signalwire.com).

## License
This project is licensed under the MIT License - see the LICENSE file for details.
