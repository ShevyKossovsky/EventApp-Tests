# Event Board Automated Tests

This repository contains automated tests for the Event Board application, implemented using C# and the NUnit testing framework. The tests aim to ensure the functionality, performance, and reliability of the Event Board application.

## Table of Contents

- [Installation](#installation)
- [Project Structure](#project-structure)
- [Running Tests](#running-tests)
- [Test Structure](#test-structure)
- [Contributing](#contributing)
- [License](#license)

## Installation

To set up the project locally, follow these steps:

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/event-board-automated-tests.git
    cd event-board-automated-tests
    ```

2. **Install dependencies:**

    Ensure you have .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet).

    ```sh
    dotnet restore
    ```

## Project Structure

The project is structured as follows:

```plaintext
event-board-automated-tests/
│
├── EventBoardTests/
│   ├── Pages/
│   │   ├── HomePage.cs
│   │   ├── EventPage.cs
│   │   └── LoginPage.cs
│   ├── Tests/
│   │   ├── HomePageTests.cs
│   │   ├── EventPageTests.cs
│   │   └── LoginPageTests.cs
│   ├── Utils/
│   │   ├── BrowserHelper.cs
│   │   ├── Config.cs
│   │   └── TestBase.cs
│   ├── EventBoardTests.csproj
│   └── appsettings.json
├── .gitignore
└── README.md
