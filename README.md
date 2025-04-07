# Paramore Brighter Redis App

This project demonstrates how to use Paramore Brighter to connect to a Redis external server for message exchange between a producer and a consumer.

## Project Structure

- **ParamoreBrighterRedisApp.sln**: Solution file that organizes the entire project.
- **Producer**: Contains the Producer component.
  - **Producer.csproj**: Project file for the Producer.
  - **Program.cs**: Entry point for the Producer application.
  - **Services/MessageProducer.cs**: Class for producing messages.
  
- **Consumer**: Contains the Consumer component.
  - **Consumer.csproj**: Project file for the Consumer.
  - **Program.cs**: Entry point for the Consumer application.
  - **Services/MessageConsumer.cs**: Class for consuming messages.

- **Shared**: Contains shared models and configurations.
  - **Shared.csproj**: Project file for shared components.
  - **Models/MessageModel.cs**: Represents the structure of messages.
  - **Config/RedisConfig.cs**: Configuration settings for Redis connection.

## Setup Instructions

1. Clone the repository.
2. Navigate to the project directory.
3. Restore the NuGet packages for all projects.
4. Configure the Redis connection settings in `Shared/Config/RedisConfig.cs`.
5. Build the solution.

## Usage

- Run the Producer to send messages to the Redis server.
- Run the Consumer to listen for and process messages from the Redis server.

## Requirements

- .NET Framework
- Redis server

## License

This project is licensed under the MIT License.# ParamoreBrighterRedisApp
