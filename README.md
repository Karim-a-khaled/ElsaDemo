# RulesEngineDemo Documentation

## Overview
The RulesEngineDemo is a demonstration project for implementing a rules engine using C#. This project showcases how to build a flexible and maintainable rules engine that can be used to evaluate complex business rules.

## Repository Structure
The repository is organized into the following main folders:

- **ElsaDemo.Api**: Contains the API layer of the application.
- **ElsaDemo.Application**: Includes application logic and services.
- **ElsaDemo.Domain**: Defines the domain models and entities.
- **ElsaDemo.Infrastructure**: Implements infrastructure and data access.

## Getting Started
### Prerequisites
- .NET SDK (version X.X)
- IDE (e.g., Visual Studio, Visual Studio Code)

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/Karim-a-khaled/ElsaDemo.git
   cd ElsaDemo
2. Restore dependencies and build the solution:
    ```sh
    dotnet restore
    dotnet build
3. Running The Application
## You will find the same ex implemented using rules engine wrokflows in [RulesEngine](https://github.com/Karim-a-khaled/RulesEngineDemo)

## Comparison between Elsa Vs Rules Engine

### Elsa Workflow
#### Purpose: Orchestrate and automate complex business processes.

#### Key Feature
    * Versatile definition methods: C#, JSON, visual designer.
    * Handles both short and long-running processes.
    * User-friendly web-based designer for visual workflow creation.
    * Supports complex workflow structures: composition, parallel execution.
    * Manages workflow versions for evolution.
    * Flexible persistence options for data storage.

## Microsoft Rules Engine
#### Purpose: Evaluate conditions and execute actions based on defined rules.
####  Key Feature
    * Rule definition using JSON for easy integration.
    * Optimized for high-performance rule evaluation.
    * Customizable with custom operators and actions.
    * Integrates seamlessly with various .NET applications.

#### Focus

    * Elsa Workflows:** Broad workflow management.
    * Microsoft Rules Engine:** Rule definition and execution.

#### Complexity

    * Elsa Workflows:** Suitable for complex workflows.
    * Microsoft Rules Engine:** Simplifies rule-based logic.

#### Design

    * Elsa Workflows: Visual designer for workflows.
    * Microsoft Rules Engine: JSON-based rule definitions.